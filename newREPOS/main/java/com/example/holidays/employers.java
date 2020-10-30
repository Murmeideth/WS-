package com.example.holidays;

public class employers {
    private int ID_employer;
    private String Name_employer;
    private String Description_epmloyer;
    private String Position_employer;

    public employers(){}
    public employers(int id, String name, String description, String position){
        this.ID_employer = id;
        this.Name_employer = name;
        this.Description_epmloyer = description;
        this.Position_employer = position;
    }

    //id
    public void setID(int id)
    {
        this.ID_employer = id;
    }
    public int getID()
    {
        return this.ID_employer;
    }


    //name
    public void setNaming(String naming)
    {
        this.Name_employer = naming;
    }
    public String getNaming()
    {
        return this.Name_employer;
    }

    //description
    public void setDescription(String description)
    {
        this.Description_epmloyer = description;
    }
    public String getDescription()
    {
        return this.Description_epmloyer;
    }


    //position
    public void setEmp(String position)
    {
        this.Position_employer = position;
    }
    public String getPosition()
    {
        return this.Position_employer;
    }

}
