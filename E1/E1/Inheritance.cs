using System.Reflection.Metadata.Ecma335;

namespace E1;

public abstract class Person
{
    #region TODO
    public virtual string Name{get=>name;set=>name =value;}
    public bool IsFemale{get;set;}
    public string name{get;set;}
    public bool isfamle{get=> IsFemale;set=>IsFemale = value;}
    public Person(string name, bool isfamel){
        this.isfamle = isfamel;
        if ( IsFemale) this.name += "خانم "+ name;
        else this.name += "آقای "+ name;
    }
    public abstract int LunchRate{get;}
    #endregion
}

public class Student:Person
{
    #region TODO
    public string name{get;}
    public bool isfml{get;}

    public override int LunchRate => 2000;

    public Student(string Name, bool IsFemale):base(Name,IsFemale){
        this.isfml= IsFemale;
        if(IsFemale) this.name = "خانم "+Name;
        this.name = "آقای "+Name;
    }
    #endregion
}

public class Employee :Person
{
    #region TODO
    public string name{get;}
    public bool isfml{get;}

    public override int LunchRate => 5000;

    public Employee (string Name, bool IsFemale): base(Name, IsFemale){
        this.isfml = IsFemale;
        if(IsFemale) this.name = "خانم "+Name ;
        else this.name = "آقای "+Name;
    }
    public virtual int CalculateSalary(int hours)=> hours*5000;
    #endregion
}

public class Teacher :Employee
{
    #region TODO
    public string name{get=>"استاد "+Name;set=>Name = value;}
    public bool isfamle{get;}
    public Teacher(string Name, bool IsFemale):base(Name, IsFemale){
        this.isfamle = IsFemale;
        this.name = "استاد "+Name;
        
    }
    public override int LunchRate => 10000;
    public override int CalculateSalary(int hours)=>hours*20000;
    
    #endregion
}