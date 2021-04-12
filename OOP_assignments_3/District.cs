using System;
namespace OOP_assignments_3
{
    class District
    {
        private string title;
        private string city;
        private Int32 districtID;
        private Officer[] officersInTheDistrict;

        public District(): this("Purvciems", "Riga", 1, new Officer[0]) {}
        public District(string title, string city, Int32 districtID, Officer[] officers)
        {
            this.title = title;
            this.city = city;
            this.districtID = districtID;
            this.officersInTheDistrict = officers;
        }
       

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string value)
        {
            title = value;
        }

        public string GetCity()
        {
            return city;
        }

        public void SetCity(string value)
        {
            city = value;
        }

        public int GetDistrictID()
        {
            return districtID;
        }

        public void SetDistrictID(int value)
        {
            districtID = value;
        }

        public Officer[] GetOfficersInTheDistrict()
        {
            return officersInTheDistrict;
        }

        public void SetOfficersInTheDistrict(Officer[] value)
        {
            officersInTheDistrict = value;
        }

        //public string toString()

        public override string ToString()
        {
            string result = $"District: {title}, city: {city}, District ID: {districtID}, Officcers: ";
            foreach (Officer officer in officersInTheDistrict)
            {
                result += " " + officer;
            }
            result += ")";
            return result;
        }

// add new officer
        public bool addNewOfficer (Officer newOfficer)
        {
            foreach (Officer existingOfficer in officersInTheDistrict)
            {
              if (existingOfficer.Equals(newOfficer)) 
              {
                  return false;
              } 
            }
        

        Officer[] newOfficers = new Officer[officersInTheDistrict.Length +1];
        for (int i=0; i < officersInTheDistrict.Length; i++)
        {
            newOfficers[i] = officersInTheDistrict[i];
        }
        newOfficers[newOfficers.Length -1] = newOfficer;
        officersInTheDistrict = newOfficers;
        return true;
        }

// remove officer
        public bool RemoveOfficer (Officer officerToRemove)
        {
            int indexToRemove = -1;
            for (int i = 0; i < officersInTheDistrict.Length; i++)
            {
                Officer existingOfficer = officersInTheDistrict[i];
                if (existingOfficer.Equals(officerToRemove))
             {
                 indexToRemove = i;
                break;
             }
                
            
            if (i == officersInTheDistrict.Length - 1)
            {
                return false;
            }
            }

            Officer[] newOfficers = new Officer[officersInTheDistrict.Length - 1];
            for (int i = 0; i < indexToRemove; i++)
            {
                newOfficers[i] = officersInTheDistrict[i];
            }
            for (int i = indexToRemove +1; i < officersInTheDistrict.Length; i++)
            {
                newOfficers[i - 1] = officersInTheDistrict[i];
            }
            officersInTheDistrict = newOfficers;
            return true;
        }
// Calculate averaga level of District
        public float CalculateAvgLevelInDistrict()
        {int sum = 0;
        foreach (Officer officer in officersInTheDistrict)
        {
            sum += officer.CalculateLevel();
        }
        return (float)sum / officersInTheDistrict.Length;
        }
        
    }
}