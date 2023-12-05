using System;
class Employee
{
	public string name, id;
	private Address address;
	public Employee(string name ,string id , Address address)
	{
		if (name == null || id== null || address==null)
		{
			throw new ArgumentNullException("Empty data field is found");
		}
		else
		{
			this.name = name;
			this.id = id;
			this.address = address;
		}
	}
    public string toString()
    {
        return "Employee Name :" + name + " \n employee ID: " + id + "\n Address details" +
			address.country + "\n"+ address.city + "\n" + address.state;

    }
}
