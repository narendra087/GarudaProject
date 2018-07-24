using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public RectTransform nameText;
	public RectTransform dialogueText;

	public Animator animator;

	private Queue<string> sentences;

	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
	}

	public void StartDialogue (Dialogue dialogue)
	{
		animator.SetBool("IsOpen", true);

		nameText.GetComponent<TMPro.TextMeshProUGUI>().text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
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

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.GetComponent<TMPro.TextMeshProUGUI>().text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
	}

}
