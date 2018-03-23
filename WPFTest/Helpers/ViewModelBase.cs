using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion INotifyPropertyChanged

        protected void Assign<T, U>(ref T privatVar, T value, Expression<Func<U>> publicVar) where T : U
        {
            var propertyName = ((MemberExpression)publicVar.Body).Member.Name;
            if (!Equals(privatVar, value))
            {
                privatVar = value;
                NotifyPropertyChanged(propertyName);
            }
        }
    }
}
