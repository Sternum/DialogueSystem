using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueController : MonoBehaviour
{
    public DialogueCanvasController DialogueCanvasController;

    private List<DialogueOptions> _dialogueOptions;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerStats>() != null)
        {
            DialogueCanvasController.StartDialogue(_dialogueOptions, other.GetComponent<PlayerStats>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerStats>() != null)
        {
            DialogueCanvasController.CloseDialogue();
        }
    }

    private void Awake()
    {
        _dialogueOptions = new List<DialogueOptions>();
        _dialogueOptions.Add(new DialogueOptions("Witaj", DialogueCanvasController.CloseDialogue));
        _dialogueOptions.Add(new DialogueOptions("Wymagana Sila", Attributes.STR, 6));
        _dialogueOptions.Add(new DialogueOptions("Wymagana Inteligencja", Attributes.INT, 2, () => { FindObjectOfType<SpawnManager>().OnSpawn();}));
        enabled = false;
    }
}
