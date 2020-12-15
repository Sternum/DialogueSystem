using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCanvasController : MonoBehaviour
{

    public GameObject dialoguePanel;

    public DialogueOptionPrefab DialogueOptionPrefab;
    
    public void StartDialogue(List<DialogueOptions> dialogueOptions, PlayerStats playerStats)
    {
        gameObject.SetActive(true);
        foreach (DialogueOptions dialogueOption in dialogueOptions)
        {
            DialogueOptionPrefab option = Instantiate(DialogueOptionPrefab);
            option.transform.SetParent(dialoguePanel.transform);
            option.dialogueOptions = dialogueOption;
            option.playerStats = playerStats;
        }
    }

    public void CloseDialogue()
    {
        foreach (Transform child in dialoguePanel.transform)
        {
            Destroy(child.gameObject);
        }
        gameObject.SetActive(false);
    }
}
