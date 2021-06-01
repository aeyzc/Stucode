using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusInt : IntCode
{
    private static string codeSyntax = "--;";
    public BaseItemCode variable;

    public MinusInt(string name,BaseItemCode variable)
    {
        this.codeType = "int";
        this.codeString = name + codeSyntax;
        this.variable = variable;

    }


    public override void codeAction()
    {
        variable.minusAction();
    }


}
