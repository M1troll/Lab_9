using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight.Command;
using System.IO;
using System.Diagnostics;

namespace BL
{
    public class Logic
    {
        private string FileName = @"BlackList.txt";
        public string HateTeacherName { get; set; }
        public string HateSubjectTitle { get; set; }
        public ObservableCollection<Teacher> MyBlackList { get; set; } = new ObservableCollection<Teacher>();
        public Logic(string login, string password)
        {
            if (login.Equals("000") && password.Equals("000"))
            {
                RestartListBox();
            }
            else { throw new AccessException("Invalid Access"); }
        }
        private RelayCommand _addNewPerson;
        public RelayCommand AddNewPerson
        {
            get { return _addNewPerson ?? (_addNewPerson = new RelayCommand(AddTeacher)); }
        }

        private RelayCommand _openBlackList;
        public RelayCommand OpenBlackList
        {
            get { return _openBlackList ?? (_openBlackList = new RelayCommand(OpenFile)); }
        }

        private RelayCommand _restartText;
        public RelayCommand RestartText
        {
            get { return _restartText ?? (_restartText = new RelayCommand(RestartListBox)); }
        }

        private void OpenFile() 
        {
            Process.Start(FileName);
        }
        
        private void RestartListBox()
        {
            string[] blacklist = File.ReadAllLines(FileName, System.Text.Encoding.GetEncoding(1251));
            if (blacklist.Length > 0)
            {
                if (blacklist.Any(x => string.IsNullOrEmpty(x.Trim())))
                {
                    var _WitoutNullLines=blacklist.Where(x => string.IsNullOrEmpty(x.Trim()) == false);
                    blacklist = _WitoutNullLines.ToArray();
                }
                MyBlackList.Clear();
                    var _MyBlackList = from line in blacklist
                                       let teacherData = line.Split('-')
                                       select new Teacher { Name = teacherData[0], Subject = new Subject() { Title = teacherData[1] } };
                    MyBlackList.AddRange(_MyBlackList.ToList());
            }
            else { MyBlackList.Clear(); }
        }

        private void AddTeacher()
        {
            if (HateSubjectTitle != null&& HateTeacherName!=null&&(!MyBlackList.Any((x => x.Name == HateTeacherName))||HateTeacherName.Equals("Не помню")))
            {
                Teacher teacher = new Teacher() {Name = HateTeacherName, Subject = new Subject() { Title = HateSubjectTitle }};
                MyBlackList.Add(teacher) ;
                using (StreamWriter w = new StreamWriter(FileName, true, Encoding.GetEncoding(1251)))
                {
                    if(MyBlackList.Count>1)w.Write("\r\n"+teacher.ToString());
                    else w.Write(teacher.ToString());
                }
            }
        }

        public List<Teacher> Teachers { get; set; } = new List<Teacher>()
        {
            new Teacher(){ Name="Виденин С.А."},
            new Teacher(){ Name="Раскина А.В."},
            new Teacher(){ Name="Кушнаренко А.В."},
            new Teacher(){ Name="Кириллова С.В."},
            new Teacher(){ Name="Гордеева А.Т."},
            new Teacher(){ Name="Лобасов А.С."},
            new Teacher(){ Name="Не помню"}
        };
        public List<Subject> Subjects { get; set; } = new List<Subject>()
        {
            new Subject(){Title="Программирование"},
            new Subject(){Title="ТиПЭРО"},
            new Subject(){Title="Физика"},
            new Subject(){Title="Мат.Анализ"},
            new Subject(){Title="Физра"},
            new Subject(){Title="Ввпд"},
            new Subject(){Title="История"},
            new Subject(){Title="Английский"},
        };
    }
}
