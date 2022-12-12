using StudentForm.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StudentForm.ViewModel
{
    internal class StudentViewModel
    {
        public StudentViewModel()
        {
            _studentEntity = new Student();
            _studentDatas = new List<Student>();
            StudentRecord = new StudentRecord();
            StudentRecords = new ObservableCollection<StudentRecord>();
            GetAll();
        }

        #region Fields
        private Student _studentEntity;
        private List<Student> _studentDatas;
        private ICommand _saveCommand;
        private ICommand _cancleCommand;
        #endregion

        #region Properties
        public StudentRecord StudentRecord { get; set; }
        public ObservableCollection<StudentRecord> StudentRecords { get; set; }
        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new ViewModelCommand(param => SaveData());
                }
                return _saveCommand;
            }
        }
        public ICommand CancleCommand
        {
            get
            {
                if (_cancleCommand == null)
                {
                    _cancleCommand = new ViewModelCommand(param => ResetData());
                }
                return _cancleCommand;
            }
        }
        #endregion

        #region Methods
        public void SaveData()
        {
            _studentEntity.Name = StudentRecord.Name;
            _studentEntity.Age = StudentRecord.Age;
            _studentEntity.Address = StudentRecord.Address;
            _studentEntity.Contact = StudentRecord.Contact;
            _studentDatas.Add(new Student
            {
                Name = _studentEntity.Name,
                Age = _studentEntity.Age,
                Address = _studentEntity.Address,
                Contact = _studentEntity.Contact
            });
            GetAll();
            ResetData();
        }
        public void ResetData()
        {
            StudentRecord.Name = null;
            StudentRecord.Age = null;
            StudentRecord.Address = null;
            StudentRecord.Contact = null;
        }
        public void GetAll()
        {
            StudentRecords.Clear();
            _studentDatas.ForEach(data => StudentRecords.Add(new StudentRecord
            {
                Name = data.Name,
                Age = data.Age,
                Address = data.Address,
                Contact = data.Contact
            }));
        }
        #endregion
    }
}
