package com.example.holidays;

public class documents {

    private int ID_doc;
    private String Name_doc;
    private String Description_doc;

    public documents(){}
    public documents(int id, String name, String description){
        this.ID_doc = id;
        this.Name_doc = name;
        this.Description_doc = description;
    }

    //id
    public void setID(int id)
    {
        this.ID_doc = id;
    }
    public int getID()
    {
        return this.ID_doc;
    }


    //name
    public void setNaming(String naming)
    {
        this.Name_doc = naming;
    }
    public String getNaming()
    {
        return this.Name_doc;
    }

    //description
    public void setDescription(String description)
    {
        this.Description_doc = description;
    }
    public String getDescription()
    {
        return this.Description_doc;
    }

}
