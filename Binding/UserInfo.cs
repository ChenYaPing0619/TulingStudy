using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingDemo
{
    internal class UserInfo:INotifyPropertyChanged
    {
		private string name;

		public string Name
		{
			get { return name; }
			set
			{
				if (name != value)
				{
					name = value;
					OnPropertyChanged(nameof(Name));
				}
			}
		}


        private string score;

        public string Score
        {
            get { return score; }
            set
            {
                if (score != value)
                {
                    score = value;
                    OnPropertyChanged(nameof(Score));
                }
            }
        }

        private UserIcons icon;

        public UserIcons Icon
        {
            get { return icon; }
            set { icon = value; }
        }


        public enum UserIcons
        {
            Bilibili,
            WeChat,
            Weibo,
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
	}
}
