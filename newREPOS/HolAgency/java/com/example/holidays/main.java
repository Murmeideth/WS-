package com.example.holidays;

public class main {
    private int ID_event;
    private String Name_event;
    private String Description_event;
    private String Emp_event;
    private String Date_event;
    private String Document_event;

    public main(){}
    public main(int id, String name_event, String description_event, String emp_event, String date_event, String document_event){
        this.ID_event = id;
        this.Name_event = name_event;
        this.Description_event = description_event;
        this.Emp_event = emp_event;
        this.Date_event = date_event;
        this.Document_event = document_event;
    }

    //id
    public void setID(int id)
    {
        this.ID_event = id;
    }
    public int getID()
    {
        return this.ID_event;
    }


    //name
    public void setNaming(String naming)
    {
        this.Name_event = naming;
    }
    public String getNaming()
    {
        return this.Name_event;
    }

    //description
    public void setDescription(String description)
    {
        this.Description_event = description;
    }
    public String getDescription()
    {
        return this.Description_event;
    }


    //employer
    public void setEmp(String emp)
    {
        this.Emp_event = emp;
    }
    public String getEmp()
    {
        return this.Emp_event;
    }


    //date
    public void setDate(String date)
    {
        this.Date_event = date;
    }
    public String getDate()
    {
        return this.Date_event;
    }


    //docs
    public void setDoc(String doc)
    {
        this.Document_event = doc;
    }
    public String getDoc()
    {
        return this.Document_event;
    }
}
