package com.example.studuchet;

public class curator {
    private int ID_cur;
    private String Name_cur;
    private String Position_cur;

    public curator(){}
    public curator(int id_cur, String name_cur, String position_cur){
        this.ID_cur = id_cur;
        this.Name_cur = name_cur;
        this.Position_cur = position_cur;
    }

    //id
    public void SetID_cur(int id) {this.ID_cur = id;}
    public int getID_cur() {return this.ID_cur;}

    //code
    public void SetName_cur(String name_cur) {this.Name_cur = name_cur;}
    public String getName_cur() {return this.Name_cur;}

    //description
    public void SetPosition_cur(String position_cur) {this.Position_cur = position_cur;}
    public String getPosition_cur() {return this.Position_cur;}
}
