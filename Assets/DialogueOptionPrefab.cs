using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueOptionPrefab : MonoBehaviour
{

    public DialogueOptions dialogueOptions;

    public  PlayerStats playerStats;
    
    private Button _button;

    private Text _label;
    
    void Start()
    {
        _button = GetComponent<Button>();
        _label = GetComponentInChildren<Text>();

        if (dialogueOptions != null)
        {
            _label.text = dialogueOptions.text;

            if (dialogueOptions.requiredAttribute != Attributes.NONE)
            {
                SetAttributeRequirement();
            }

            if (dialogueOptions.DialogueAction != null)
            {
                _button.onClick.AddListener(dialogueOptions.DialogueAction.Invoke);
            }
        }
    }

    private void SetAttributeRequirement()
    {
        switch (dialogueOptions.requiredAttribute)
        {
            case Attributes.STR:
            {
                _button.interactable = playerStats.Strength > dialogueOptions.requiredAttributeLvl;
                _label.text = _label.text + " (STR " + playerStats.Strength + "/" + dialogueOptions.requiredAttributeLvl + ")";
                break;
            }
            case Attributes.INT:
            {
                _button.interactable = playerStats.Inteligence > dialogueOptions.requiredAttributeLvl;
                _label.text = _label.text + " (INT " + playerStats.Inteligence + "/" + dialogueOptions.requiredAttributeLvl + ")";
                break;
            }
            case Attributes.DEX:
            {
                _button.interactable = playerStats.Dexternity > dialogueOptions.requiredAttributeLvl;
                _label.text = _label.text + " (DEX " + playerStats.Dexternity + "/" + dialogueOptions.requiredAttributeLvl + ")";
                break;
            }
        }
    }
}
