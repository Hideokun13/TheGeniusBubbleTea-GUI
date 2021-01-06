using System;
using System.Collections.Generic;
using System.Text;

namespace TheGenuisBubbleTea_GUI
{
    class Member
    {
        private string name;
        private string surname;
        private string telNumber;
        private string registerDate;

        List<Member> members = new List<Member>();

        FileManagement registerFile = new FileManagement(System.AppDomain.CurrentDomain.BaseDirectory + "/Member/Member.txt");
        public Member()
        {

        }
        public Member(string name, string surname, string telNumber, string registerDate)
        {
            this.name = name;
            this.surname = surname;
            this.telNumber = telNumber;
            this.registerDate = registerDate;
        }
        public string Name
        {
            get { return name; }
        }
        public string Surname
        {
            get { return surname; }
        }
        public string TelNumber
        {
            get { return telNumber; }
        }
        public string RegisterDate
        {
            get { return registerDate; }
        }
        public bool RegisterMember()
        {
            bool isRegester = false;
            Member registerMember = new Member(name, surname, telNumber, registerDate);
            members.Add(registerMember);

            List<string> content = new List<string>();

            foreach (Member i in members)
            {
                string temp = i.Name + "," + i.Surname + "," + i.TelNumber + "," + i.RegisterDate;
                content.Add(temp);
            }
            if (registerFile.WriteAppendFile(content))
            {
                return isRegester = true;
            }
            return isRegester;
        }
        public bool CheckMember(string telNumber)
        {
            bool isMatch = false;

            List<string> member = new List<string>();
            foreach (string i in registerFile.ReadFile())
            {
                if (i != "")
                {
                    string[] mem = new string[3];
                    mem = i.Split(",");
                    string _name = mem[0];
                    string _surname = mem[1];
                    string _telNumber = mem[2];
                    if (_telNumber == telNumber)
                    {
                        return isMatch = true;
                    }
                }
            }
            return isMatch;
        }
        public string PrintMemberInfo(string telNumber)
        {
            foreach (string i in registerFile.ReadFile())
            {
                if (i != "")
                {
                    string[] mem = new string[4];
                    mem = i.Split(",");
                    string _name = mem[0];
                    string _surname = mem[1];
                    string _telNumber = mem[2];
                    string _registerDate = mem[3];
                    if (_telNumber == telNumber)
                    {
                        return _name + "," + _surname + "," + _telNumber + "," + _registerDate;
                    }
                }
            }
            return "";
        }
    }
}
