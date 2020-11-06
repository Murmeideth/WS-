package com.example.studuchet;

public class groups {
    private int ID_group;
    private String Code_group;
    private String Description_group;

    public groups(){}
    public groups(int id_group, String code_group, String description_group){
        this.ID_group = id_group;
        this.Code_group = code_group;
        this.Description_group = description_group;
    }

    //id
    public void SetID_group(int id) {this.ID_group = id;}
    public int getID_group() {return this.ID_group;}

    //code
    public void SetCode_Group(String code_group) {this.Code_group = code_group;}
    public String getCode_group() {return this.Code_group;}

    //description
    public void SetDescription_group(String description_group) {this.Description_group = description_group;}
    public String getDescription_group() {return this.Description_group;}
}
