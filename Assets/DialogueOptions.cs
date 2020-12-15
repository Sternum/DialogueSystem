
using UnityEngine;

public delegate void DialogueAction();

public class DialogueOptions
{
    public string text;
    public Attributes requiredAttribute;
    public int requiredAttributeLvl;
    public DialogueAction DialogueAction;
    
    public DialogueOptions(string text, DialogueAction action = null)
    {
        this.text = text;
        requiredAttribute = Attributes.NONE;
        requiredAttributeLvl = 0;
        DialogueAction = action;
    }

    public DialogueOptions(string text, Attributes requiredAttribute, int requiredAttributeLvl, DialogueAction action = null)
    {
        this.text = text;
        this.requiredAttribute = requiredAttribute;
        this.requiredAttributeLvl = requiredAttributeLvl;
        DialogueAction = action;
    }
}