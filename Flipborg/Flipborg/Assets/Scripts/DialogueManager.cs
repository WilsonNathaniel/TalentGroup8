using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

	//public TextMeshProUGUI nameText;
	public TextMeshProUGUI dialogueText;
	public Animator animator;
	public float typespeed;
	private Queue<string> sentences;

	// Use this for initialization
	void Awake()
	{
		sentences = new Queue<string>();
	}

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
			DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
	{
		Time.timeScale = 0f;
		animator.SetBool("IsOpen", true);

		//nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence(string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return new WaitForSecondsRealtime(typespeed);
		}
	}

	void EndDialogue()
	{
		Time.timeScale = 1f;
		animator.SetBool("IsOpen", false);
	}

}
