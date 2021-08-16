using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    public string nombre;
    public string dialogo;
    public Sprite retrato;
}


public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public TextMeshProUGUI dialogoText;
    public TextMeshProUGUI nombre;
    public Image portrait;
    public List<Dialogue> dialogos;
    public int index;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        ShowDialogue(dialogos[0]);
    }
    public void ShowDialogue(Dialogue dialogue)
    {
        nombre.text = dialogue.nombre;
        dialogoText.text = dialogue.dialogo;
        portrait.sprite = dialogue.retrato;
    }
    public void NextDialgogue()
    {
        index++;
        if(index >= dialogos.Count)
        {
            index = 0;
            //termina dialogo
        }
        else
        {
            ShowDialogue(dialogos[index]);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("IndexDialogue", index);
    }
    public void Load()
    {
        index = PlayerPrefs.GetInt("IndexDialogue");
        ShowDialogue(dialogos[index]); 
    }
    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
        ShowDialogue(dialogos[0]);
    }
}
