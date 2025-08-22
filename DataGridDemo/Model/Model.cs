using Syncfusion.Windows.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace DataGridDemo
{
    public class OrderInfo : NotificationObject
    {
       
        private CustomerInfo _Customers;
        private ShipperDetails[] shippersInfo;

        public OrderInfo()
        {

        }

        public CustomerInfo Customers
        {
            get
            {
                return _Customers;
            }
            set
            {
                _Customers = value;
                RaisePropertyChanged("Customers");
            }
        }

        public ShipperDetails[] ShippersInfo
        {
            get
            {
                return shippersInfo;
            }
            set
            {
                shippersInfo = value;
                RaisePropertyChanged("ShippersInfo");
            }
        }
    }

    public class CustomerInfo : NotificationObject,INotifyDataErrorInfo
    {
        private string _customerName;
        private string _country;
        private string _city;

        public CustomerInfo()
        {

        }

        private List<string> errors = new List<string>();
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                _customerName = value;
                RaisePropertyChanged("CustomerName");
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                RaisePropertyChanged("City");
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
                RaisePropertyChanged("Country");
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {

            if (propertyName.Equals("Country") || propertyName.Equals("City"))
                return null;

            if (this.CustomerName.Contains("Hardy"))
                errors.Add("Invalid customer name");

            return errors;
        }

        public bool HasErrors
        {
            get
            {
                return false;
            }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    }

    public class ShipperDetails : NotificationObject,INotifyDataErrorInfo
    {
        private int _ShipperID;

        private string _CompanyName;

        public ShipperDetails()
        {

        }

        private List<string> errors = new List<string>();

        public int ShipperID
        {
            get
            {
                return _ShipperID;
            }
            set
            {
                _ShipperID = value;
                RaisePropertyChanged("ShipperID");
            }
        }

        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                _CompanyName = value;
                RaisePropertyChanged("CompanyName");
            }
        }

        public IEnumerable GetErrors(string propertyName)
        {

            if (propertyName== "ShipperID" && this.ShipperID == 3)
                errors.Add("Invalid shipper id");

            return errors;
        }

        public bool HasErrors
        {
            get
            {
                return false;
            }
        }

        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

    }
}
