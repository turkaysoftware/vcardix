using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCardix{
    internal class VCardixModule{
        // VCARD VERSION
        // ======================================================================================================
        public enum VCardVersion { [Description("2.1")] V21, [Description("3.0")] V30, [Description("4.0")] V40 }
        public VCardVersion CurrentVersion { get; set; } = VCardVersion.V40;
        // ID-BASED FAST ACCESS DICTIONARY
        // ======================================================================================================
        private readonly Dictionary<Guid, PrefixModule> contactsById = new Dictionary<Guid, PrefixModule>();
        // PUBLIC READONLY LIST IF YOU WANT, WE WILL PROVIDE IT, WE USED DICTIONARY FOR PERFORMANCE
        // ======================================================================================================
        public IReadOnlyCollection<PrefixModule> ContactsList => contactsById.Values;
        // PREFIX
        public class PrefixModule{
            // UID
            public Guid Id { get; set; } = Guid.NewGuid();
            // NAME
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            // BIRTHDAY
            public DateTime? Birthday { get; set; }
            // PHONE
            public string PhoneMobile { get; set; }
            public string PhoneHome { get; set; }
            public string PhoneWork { get; set; }
            // EMAIL
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public string Email3 { get; set; }
            // OTHER INFO
            public string Address { get; set; }
            public string Organization { get; set; }
            public string Website { get; set; }
            public string Note { get; set; }
            // PHOTO
            public string PhotoBase64 { get; set; }
            // NAME PREFIX
            public string FullName => string.Join(" ", new[] { FirstName, MiddleName, LastName }.Where(p => !string.IsNullOrWhiteSpace(p)));
            // IMAGE PREFIX
            public Image PhotoImage{ get{ return TSImageHelper.ImageFromBase64(PhotoBase64); } }
            // IMAGE CLEAR
            public void ClearPhoto(){ PhotoBase64 = null; }
        }
        // ADD DATA
        // ======================================================================================================
        public void AddContact(PrefixModule contact){
            if (contact == null) { throw new ArgumentNullException(nameof(contact)); }
            if (contact.Id == Guid.Empty){ contact.Id = Guid.NewGuid(); }
            contactsById[contact.Id] = contact;
        }
        // UPDATE DATA
        // ======================================================================================================
        public bool UpdateContact(Guid id, PrefixModule updated){
            if (!contactsById.ContainsKey(id)){  return false; }
            var existing = contactsById[id];
            //
            existing.FirstName = updated.FirstName;
            existing.MiddleName = updated.MiddleName;
            existing.LastName = updated.LastName;
            //
            existing.Birthday = updated.Birthday;
            //
            existing.PhoneMobile = updated.PhoneMobile;
            existing.PhoneHome = updated.PhoneHome;
            existing.PhoneWork = updated.PhoneWork;
            //
            existing.Email1 = updated.Email1;
            existing.Email2 = updated.Email2;
            existing.Email3 = updated.Email3;
            //
            existing.Address = updated.Address;
            existing.Organization = updated.Organization;
            existing.Website = updated.Website;
            existing.Note = updated.Note;
            return true;
        }
        // DELETE DATA
        // ======================================================================================================
        public bool DeleteContact(Guid id){ return contactsById.Remove(id); }
        // VCARD LOAD/SAVE
        // ======================================================================================================
        public void LoadVcf(string filePath)
        {
            contactsById.Clear();
            //
            var lines = File.ReadAllLines(filePath, Encoding.UTF8);
            var vcardBlocks = new List<List<string>>();
            List<string> currentBlock = null;
            //
            foreach (var line in lines)
            {
                if (line.StartsWith("BEGIN:VCARD"))
                {
                    currentBlock = new List<string>();
                    vcardBlocks.Add(currentBlock);
                }
                currentBlock?.Add(line);
                if (line.StartsWith("END:VCARD"))
                {
                    currentBlock = null;
                }
            }
            var lockObj = new object();
            Parallel.ForEach(vcardBlocks, block =>
            {
                var current = new PrefixModule();
                string currentVersion = null;

                foreach (var line in block)
                {
                    if (line.StartsWith("VERSION:"))
                    {
                        currentVersion = line.Substring(8).Trim();
                    }
                    else if (line.StartsWith("UID:"))
                    {
                        var uidText = line.Substring(4).Trim();
                        if (Guid.TryParse(uidText, out var guid))
                            current.Id = guid;
                        else
                            current.Id = Guid.NewGuid();
                    }
                    else if (line.StartsWith("N:"))
                    {
                        var parts = line.Substring(2).Split(';');
                        current.LastName = parts.Length > 0 ? parts[0] : "";
                        current.FirstName = parts.Length > 1 ? parts[1] : "";
                        current.MiddleName = parts.Length > 2 ? parts[2] : "";
                    }
                    else if ((line.StartsWith("TEL;CELL:") || line.StartsWith("TEL;TYPE=CELL:")))
                    {
                        var val = line.Substring(line.IndexOf(':') + 1).Trim();
                        current.PhoneMobile = val;
                    }
                    else if ((line.StartsWith("TEL;HOME:") || line.StartsWith("TEL;TYPE=HOME:")))
                    {
                        var val = line.Substring(line.IndexOf(':') + 1).Trim();
                        current.PhoneHome = val;
                    }
                    else if ((line.StartsWith("TEL;WORK:") || line.StartsWith("TEL;TYPE=WORK:")))
                    {
                        var val = line.Substring(line.IndexOf(':') + 1).Trim();
                        current.PhoneWork = val;
                    }
                    else if (line.StartsWith("EMAIL;"))
                    {
                        var idx = line.IndexOf(':');
                        if (idx >= 0)
                        {
                            var email = line.Substring(idx + 1).Trim();
                            if (string.IsNullOrEmpty(current.Email1))
                                current.Email1 = email;
                            else if (string.IsNullOrEmpty(current.Email2))
                                current.Email2 = email;
                            else
                                current.Email3 = email;
                        }
                    }
                    else if (line.StartsWith("PHOTO;ENCODING=b"))
                    {
                        var colonIndex = line.IndexOf(':');
                        if (colonIndex >= 0 && colonIndex + 1 < line.Length)
                        {
                            var base64 = line.Substring(colonIndex + 1).Trim();
                            current.PhotoBase64 = base64;
                        }
                    }
                    else if (line.StartsWith("URL:"))
                    {
                        current.Website = line.Substring(4).Trim();
                    }
                    else if (line.StartsWith("NOTE:"))
                    {
                        current.Note = line.Substring(5).Trim();
                    }
                    else if (line.StartsWith("ORG:"))
                    {
                        current.Organization = line.Substring(4).Trim();
                    }
                    else if (line.StartsWith("ADR"))
                    {
                        var adrIndex = line.IndexOf(':');
                        if (adrIndex >= 0)
                        {
                            var adr = line.Substring(adrIndex + 1).Trim();
                            current.Address = adr.Replace(";", "||");
                        }
                    }
                    else if (line.StartsWith("BDAY:"))
                    {
                        if (DateTime.TryParse(line.Substring(5).Trim(), out DateTime dt))
                            current.Birthday = dt;
                    }
                }
                if (!string.IsNullOrEmpty(currentVersion))
                {
                    if (currentVersion == "2.1") CurrentVersion = VCardVersion.V21;
                    else if (currentVersion == "3.0") CurrentVersion = VCardVersion.V30;
                    else if (currentVersion == "4.0") CurrentVersion = VCardVersion.V40;
                }
                lock (lockObj)
                {
                    AddContact(current);
                }
            });
        }
        public void SaveVcf(string filePath){
            var sb = new StringBuilder(ContactsList.Count * 512);
            foreach (var c in ContactsList){
                sb.AppendLine("BEGIN:VCARD");
                switch (CurrentVersion){
                    case VCardVersion.V21:
                        sb.AppendLine("VERSION:2.1");
                        sb.AppendLine($"UID:{c.Id}");
                        sb.AppendLine($"N:{c.LastName};{c.FirstName};{c.MiddleName}");
                        sb.AppendLine($"FN:{c.FullName}");
                        if (c.Birthday.HasValue)
                            sb.AppendLine($"BDAY:{c.Birthday.Value:yyyy-MM-dd}");
                        if (!string.IsNullOrEmpty(c.PhoneMobile))
                            sb.AppendLine($"TEL;CELL:{c.PhoneMobile}");
                        if (!string.IsNullOrEmpty(c.PhoneHome))
                            sb.AppendLine($"TEL;HOME:{c.PhoneHome}");
                        if (!string.IsNullOrEmpty(c.PhoneWork))
                            sb.AppendLine($"TEL;WORK:{c.PhoneWork}");
                        if (!string.IsNullOrEmpty(c.Email1))
                            sb.AppendLine($"EMAIL;INTERNET:{c.Email1}");
                        if (!string.IsNullOrEmpty(c.Email2))
                            sb.AppendLine($"EMAIL;INTERNET:{c.Email2}");
                        if (!string.IsNullOrEmpty(c.Email3))
                            sb.AppendLine($"EMAIL;INTERNET:{c.Email3}");
                        if (!string.IsNullOrEmpty(c.Address)){
                            var parts = c.Address.Split(new[] { "||" }, StringSplitOptions.None);
                            sb.AppendLine(parts.Length == 7 ? $"ADR;TYPE=HOME:{string.Join(";", parts)}" : "ADR;TYPE=HOME:;;;;;;;");
                        }
                        if (!string.IsNullOrEmpty(c.Organization))
                            sb.AppendLine($"ORG:{c.Organization}");
                        if (!string.IsNullOrEmpty(c.Website))
                            sb.AppendLine($"URL:{c.Website}");
                        if (!string.IsNullOrEmpty(c.Note))
                            sb.AppendLine($"NOTE:{c.Note}");
                        if (!string.IsNullOrEmpty(c.PhotoBase64))
                            sb.AppendLine($"PHOTO;ENCODING=b;TYPE=JPEG:{c.PhotoBase64}");
                        break;
                    case VCardVersion.V30:
                    case VCardVersion.V40:
                    default:
                        sb.AppendLine($"VERSION:{(CurrentVersion == VCardVersion.V30 ? "3.0" : "4.0")}");
                        sb.AppendLine($"UID:{c.Id}");
                        sb.AppendLine($"N:{c.LastName};{c.FirstName};{c.MiddleName}");
                        sb.AppendLine($"FN:{c.FullName}");
                        if (c.Birthday.HasValue)
                            sb.AppendLine($"BDAY:{c.Birthday.Value:yyyy-MM-dd}");
                        if (!string.IsNullOrEmpty(c.PhoneMobile))
                            sb.AppendLine($"TEL;TYPE=CELL:{c.PhoneMobile}");
                        if (!string.IsNullOrEmpty(c.PhoneHome))
                            sb.AppendLine($"TEL;TYPE=HOME:{c.PhoneHome}");
                        if (!string.IsNullOrEmpty(c.PhoneWork))
                            sb.AppendLine($"TEL;TYPE=WORK:{c.PhoneWork}");
                        if (!string.IsNullOrEmpty(c.Email1))
                            sb.AppendLine($"EMAIL;TYPE=INTERNET:{c.Email1}");
                        if (!string.IsNullOrEmpty(c.Email2))
                            sb.AppendLine($"EMAIL;TYPE=INTERNET:{c.Email2}");
                        if (!string.IsNullOrEmpty(c.Email3))
                            sb.AppendLine($"EMAIL;TYPE=INTERNET:{c.Email3}");
                        if (!string.IsNullOrEmpty(c.Address)){
                            var parts = c.Address.Split(new[] { "||" }, StringSplitOptions.None);
                            sb.AppendLine(parts.Length == 7 ? $"ADR;TYPE=HOME:{string.Join(";", parts)}" : "ADR;TYPE=HOME:;;;;;;;");
                        }
                        if (!string.IsNullOrEmpty(c.Organization))
                            sb.AppendLine($"ORG:{c.Organization}");
                        if (!string.IsNullOrEmpty(c.Website))
                            sb.AppendLine($"URL:{c.Website}");
                        if (!string.IsNullOrEmpty(c.Note))
                            sb.AppendLine($"NOTE:{c.Note}");
                        if (!string.IsNullOrEmpty(c.PhotoBase64))
                            sb.AppendLine($"PHOTO;ENCODING=b;TYPE=JPEG:{c.PhotoBase64}");
                        break;
                }
                sb.AppendLine("END:VCARD");
            }
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }
        // CSV LOAD/SAVE
        // ======================================================================================================
        public void LoadCsv(string filePath){
            contactsById.Clear();
            var lines = File.ReadAllLines(filePath, Encoding.UTF8);
            if (lines.Length == 0) return;
            var headers = ParseCsvLine(lines[0]);
            int FindIndex(string colName) =>
                Array.FindIndex(headers, h => string.Equals(h, colName, StringComparison.OrdinalIgnoreCase));
            var idIndex = FindIndex("Id");
            var firstNameIndex = FindIndex("FirstName");
            var middleNameIndex = FindIndex("MiddleName");
            var lastNameIndex = FindIndex("LastName");
            var birthdayIndex = FindIndex("Birthday");
            var phoneMobileIndex = FindIndex("PhoneMobile");
            var phoneHomeIndex = FindIndex("PhoneHome");
            var phoneWorkIndex = FindIndex("PhoneWork");
            var email1Index = FindIndex("Email1");
            var email2Index = FindIndex("Email2");
            var email3Index = FindIndex("Email3");
            var addressIndex = FindIndex("Address");
            var organizationIndex = FindIndex("Organization");
            var websiteIndex = FindIndex("Website");
            var noteIndex = FindIndex("Note");
            var photoIndex = FindIndex("PhotoBase64");
            var contactList = new PrefixModule[lines.Length - 1];
            Parallel.For(1, lines.Length, i =>{
                var values = ParseCsvLine(lines[i]);
                if (values.Length == 0) return;
                var contact = new PrefixModule();
                if (idIndex >= 0 && idIndex < values.Length && Guid.TryParse(values[idIndex], out var guid))
                    contact.Id = guid;
                else
                    contact.Id = Guid.NewGuid();
                if (firstNameIndex >= 0 && firstNameIndex < values.Length)
                    contact.FirstName = values[firstNameIndex];
                if (middleNameIndex >= 0 && middleNameIndex < values.Length)
                    contact.MiddleName = values[middleNameIndex];
                if (lastNameIndex >= 0 && lastNameIndex < values.Length)
                    contact.LastName = values[lastNameIndex];
                if (birthdayIndex >= 0 && birthdayIndex < values.Length && DateTime.TryParse(values[birthdayIndex], out var dt))
                    contact.Birthday = dt;
                if (phoneMobileIndex >= 0 && phoneMobileIndex < values.Length)
                    contact.PhoneMobile = values[phoneMobileIndex];
                if (phoneHomeIndex >= 0 && phoneHomeIndex < values.Length)
                    contact.PhoneHome = values[phoneHomeIndex];
                if (phoneWorkIndex >= 0 && phoneWorkIndex < values.Length)
                    contact.PhoneWork = values[phoneWorkIndex];
                if (email1Index >= 0 && email1Index < values.Length)
                    contact.Email1 = values[email1Index];
                if (email2Index >= 0 && email2Index < values.Length)
                    contact.Email2 = values[email2Index];
                if (email3Index >= 0 && email3Index < values.Length)
                    contact.Email3 = values[email3Index];
                if (addressIndex >= 0 && addressIndex < values.Length)
                    contact.Address = values[addressIndex];
                if (organizationIndex >= 0 && organizationIndex < values.Length)
                    contact.Organization = values[organizationIndex];
                if (websiteIndex >= 0 && websiteIndex < values.Length)
                    contact.Website = values[websiteIndex];
                if (noteIndex >= 0 && noteIndex < values.Length)
                    contact.Note = values[noteIndex];
                if (photoIndex >= 0 && photoIndex < values.Length)
                    contact.PhotoBase64 = values[photoIndex];
                contactList[i - 1] = contact;
            });
            foreach (var contact in contactList){
                if (contact != null)
                    AddContact(contact);
            }
        }
        public void SaveCsv(string filePath){
            using (var sw = new StreamWriter(filePath, false, Encoding.UTF8)){
                sw.WriteLine("Id,FirstName,MiddleName,LastName,Birthday,PhoneMobile,PhoneHome,PhoneWork,Email1,Email2,Email3,Address,Organization,Website,Note,PhotoBase64");
                foreach (var c in ContactsList){
                    var line = string.Join(",",
                        EscapeCsv(c.Id.ToString()),
                        EscapeCsv(c.FirstName),
                        EscapeCsv(c.MiddleName),
                        EscapeCsv(c.LastName),
                        c.Birthday.HasValue ? c.Birthday.Value.ToString("yyyy-MM-dd") : "",
                        EscapeCsv(c.PhoneMobile),
                        EscapeCsv(c.PhoneHome),
                        EscapeCsv(c.PhoneWork),
                        EscapeCsv(c.Email1),
                        EscapeCsv(c.Email2),
                        EscapeCsv(c.Email3),
                        EscapeCsv(c.Address),
                        EscapeCsv(c.Organization),
                        EscapeCsv(c.Website),
                        EscapeCsv(c.Note),
                        EscapeCsv(c.PhotoBase64)
                    );
                    sw.WriteLine(line);
                }
            }
        }
        private string EscapeCsv(string s){
            if (string.IsNullOrEmpty(s)) return "";
            if (s.Contains(",") || s.Contains("\"") || s.Contains("\n")){
                s = s.Replace("\"", "\"\"");
                return $"\"{s}\"";
            }
            return s;
        }
        // ADVANCED PARSE CVS LINE
        // ======================================================================================================
        private string[] ParseCsvLine(string line){
            var values = new List<string>();
            int i = 0;
            var sb = new StringBuilder();
            bool inQuotes = false;
            //
            while (i < line.Length){
                char c = line[i];
                if (c == '"'){
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '"'){
                        sb.Append('"');
                        i++;
                    }else{
                        inQuotes = !inQuotes;
                    }
                }else if (c == ',' && !inQuotes){
                    values.Add(sb.ToString());
                    sb.Clear();
                }else{
                    sb.Append(c);
                }
                i++;
            }
            //
            values.Add(sb.ToString());
            return values.ToArray();
        }
        // DYNAMIC ADVANCED SEARCH ENGINE
        // ======================================================================================================
        public IEnumerable<PrefixModule> SearchContacts(string keyword){
            if (string.IsNullOrWhiteSpace(keyword)){  return ContactsList; }
            keyword = keyword.ToLower();
            return ContactsList.Where(c =>
                new[]{
                    c.FirstName,
                    c.MiddleName,
                    c.LastName,
                    c.PhoneMobile,
                    c.PhoneHome,
                    c.PhoneWork,
                    c.Email1,
                    c.Email2,
                    c.Email3,
                    c.Address,
                    c.Organization,
                    c.Website,
                    c.Note
                }.Any(field => !string.IsNullOrEmpty(field) && field.ToLower().Contains(keyword))
            ).ToList();
        }
    }
    // TS IMAGE HELPER
    // ======================================================================================================
    public class TSImageHelper{
        public static Image ImageFromBase64(string base64){
            if (string.IsNullOrEmpty(base64)){ return null; }
            try{
                byte[] bytes = Convert.FromBase64String(base64);
                MemoryStream ms = new MemoryStream(bytes);
                Image img = Image.FromStream(ms);
                return (Image)img.Clone();
            }catch{
                return null;
            }
        }
        public static void SetPictureBoxImage(PictureBox pictureBox, Image newImage){
            if (pictureBox.Image != null){
                pictureBox.Image.Dispose();
                pictureBox.Image = null;
            }
            if (newImage != null){
                pictureBox.Image = (Image)newImage.Clone();
            }else{
                pictureBox.Image = null;
            }
        }
    }
}