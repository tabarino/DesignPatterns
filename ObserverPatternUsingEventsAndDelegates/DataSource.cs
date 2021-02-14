using System;
namespace ObserverPatternUsingEventsAndDelegates
{
    public class DataSource
    {
        private int _value;

        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                Update();
            }
        }

        public event EventHandler<DataSourceEventArgs> DataSourceUpdated;

        public void Update()
        {
            OnDataSourceUpdated();
        }

        protected virtual void OnDataSourceUpdated()
        {
            if (DataSourceUpdated != null)
            {
                DataSourceUpdated(this, new DataSourceEventArgs() { DataSource = this });
            }
        }
    }
}
