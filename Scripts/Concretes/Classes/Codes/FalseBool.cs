using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseBool : BoolCode
{
    private static string codeSyntax = "=false;";
    public BaseItemCode variable;

    public FalseBool(string name, BaseItemCode variable)
    {
        this.codeType = "bool";
        this.codeString = name + codeSyntax;
        this.variable = variable;

    }


    public override void codeAction()
    {
        variable.falseAction();
    }


}
