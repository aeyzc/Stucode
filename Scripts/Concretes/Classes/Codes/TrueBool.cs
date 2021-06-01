using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueBool : BoolCode
{
    private static string codeSyntax = "=true;";
    public BaseItemCode variable;

    public TrueBool(string name, BaseItemCode variable)
    {
        this.codeType = "bool";
        this.codeString = name + codeSyntax;
        this.variable = variable;

    }


    public override void codeAction()
    {
        variable.trueAction();
    }


}
