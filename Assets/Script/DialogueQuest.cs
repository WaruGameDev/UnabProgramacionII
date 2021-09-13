using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueQuest : MonoBehaviour
{
    public List<string> dialogues;
    public CanvasGroup panelText;
    public TextMeshProUGUI textDialogue;
    
    public void ShowDialogue()
    {
        QuestGiver qg = GetComponent<QuestGiver>();
        textDialogue.text = dialogues[(int)QuestManager.instance.GetQuestState(qg.questsToGive[0].nombreQuest)];
        panelText.alpha = 1;

    }

}
