namespace StudentForm.ViewModel
{
    internal class StudentRecord : ViewModelBase
    {
        #region Fields
        private string _name;
        private short? _age;
        private string _address;
        private string _contact;
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public short? Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }
        public string Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
