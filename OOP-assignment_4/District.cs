using System;

namespace OOP_assignment_4
{
    class  District
    {
        private string title;
        private string city;
        private Int32 districtID;
        private Person[] personsInTheDistrict;

        public District(): this("Purvciems", "Riga", 1, new Person[0]) {}
        public District(string title, string city, Int32 districtID, Person[] persons)
        {
            this.title = title;
            this.city = city;
            this.districtID = districtID;
            this.personsInTheDistrict = persons;
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

        public Person[] GetPersonsInTheDistrict()
        {
            return personsInTheDistrict;
        }

        public void SetPersonsInTheDistrict(Person[] value)
        {
            personsInTheDistrict = value;
        }

        //public string toString()

        public override string ToString()
        {
            string result = $"District: {title}, city: {city}, District ID: {districtID}, Persons: ";
            foreach (Person person in personsInTheDistrict)
            {
                result += " " + person;
            }
            result += ")";
            return result;
        }

// add new officer
        public bool addNewPerson (Person newPerson)
        {
            foreach (Person existingPerson in personsInTheDistrict)
            {
              if (existingPerson.Equals(newPerson)) 
              {
                  return false;
              } 
            }
        

        Person[] newPersons = new Person[personsInTheDistrict.Length +1];
        for (int i=0; i < personsInTheDistrict.Length; i++)
        {
            newPersons[i] = personsInTheDistrict[i];
        }
        newPersons[newPersons.Length -1] = newPerson;
        personsInTheDistrict = newPersons;
        return true;
        }

// remove Person
        public bool RemovePerson (Person personToRemove)
        {
            int indexToRemove = -1;
            for (int i = 0; i < personsInTheDistrict.Length; i++)
            {
                Person existingPerson = personsInTheDistrict[i];
                if (existingPerson.Equals(personToRemove))
             {
                 indexToRemove = i;
                break;
             }
                
            
            if (i == personsInTheDistrict.Length - 1)
            {
                return false;
            }
            }

            Person[] newPersons = new Person[personsInTheDistrict.Length - 1];
            for (int i = 0; i < indexToRemove; i++)
            {
                newPersons[i] = personsInTheDistrict[i];
            }
            for (int i = indexToRemove +1; i < personsInTheDistrict.Length; i++)
            {
                newPersons[i - 1] = personsInTheDistrict[i];
            }
            personsInTheDistrict = newPersons;
            return true;
        }
// Calculate average level of District
        public float CalculateAvgLevelInDistrict()
        {int sum = 0, count = 0;
        foreach (Person person in personsInTheDistrict)
        {
            if(person is Officer)
            {
                sum += ((Officer)person).CalculateLevel();
                count ++;
            }
            
        }
        return (float)sum / count;
        }
    }
}