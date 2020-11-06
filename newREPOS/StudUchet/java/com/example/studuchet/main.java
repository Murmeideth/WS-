package com.example.studuchet;

public class main {
    private int ID_stud;
    private String Name_stud;
    private String Group_stud;
    private String Curator_stud;

    public main(){}
    public main(int id_stud, String name_stud, String group_stud, String curator_stud){
        this.ID_stud = id_stud;
        this.Name_stud = name_stud;
        this.Group_stud = group_stud;
        this.Curator_stud = curator_stud;
    }

    //id
    public void setID_stud(int id){this.ID_stud = id;}
    public int getID_stud() {return this.ID_stud;}

    //name
    public void setName_stud(String name_stud){this.Name_stud = name_stud;}
    public String getName_stud() {return this.Name_stud;}

    //group
    public void setGroup_stud(String group_stud){this.Group_stud = group_stud;}
    public String getGroup_stud() {return this.Group_stud;}

    //curator
    public void setCurator_stud(String curator_stud){this.Curator_stud = curator_stud;}
    public String getCurator_stud() {return this.Curator_stud;}
}
