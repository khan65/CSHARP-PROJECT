using System;

    public class Address
    {
        private string roadNo;
        private string houseNo;
        private string city; 
        private string country;

        public Address()
        {

        }
        public string RoadNo
        {
            set
            {
                this.roadNo = value;
            }
            get
            {
                 return this.roadNo; 
            }

        } 
        public string HouseNo
        {
            set
            {
                this.houseNo = value;
            }
            get
            { 
                return this.houseNo;
            }

        }

        public string City
        {
            set
            {
                this.city = value;
            }
            get
            { 
                return this.city;
            }

        }

        public string Country
        {
            set
            {
                this.country = value;
            }
            get
            { 
                return this.country;
            }

        }
		public Address(string roadNo,string houseNo,string city,string country)
        {
            this.roadNo = roadNo;
            this.houseNo = houseNo;
            this.city = city;
            this.country = country;
        }
        public void ShowAddress()
        {
            Console.WriteLine("Road No: " + roadNo);
            Console.WriteLine("House No: " + houseNo);
            Console.WriteLine("City: " + city);
            Console.WriteLine("Country: " + country);

        }


    }

