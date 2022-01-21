using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ComputerLogInScreen : MonoBehaviour
{
	public float delay = 0.1f;
	public float textDelay;
	[Header("First Text")]
	public string firstText;
	public Text firstSelectedText;
	private string currentText = "";

	[Header("Second Text")]
	public string secondText;
	public Text secondSelectedText;
	private string currentText2 = "";

	[Header("Check If Completed")]
	public bool firstOne;
	public bool secondOne;

	[Header("Button Settings")]
	public Button logIn;

	// Use this for initialization
	void Start()
	{
		StartCoroutine(WaitForSecondsShowText());
	}

	public void CheckIfDone()
    {
		if(firstSelectedText.text == firstText && firstOne == false)
        {
			firstOne = true;
			Debug.Log("FirstOneCompleted");
        }

		if (secondSelectedText.text == secondText)
		{
			secondOne = true;
			Debug.Log("SecondOneCompleted");
			logIn.GetComponent<Button>().interactable = true;
		}
	}

	IEnumerator ShowText()
	{
		for (int i = 0; i < firstText.Length + 1; i++)
		{
			currentText = firstText.Substring(0, i);
			firstSelectedText.text = currentText;
			yield return new WaitForSeconds(delay);
			CheckIfDone();
		}
		if(firstOne == true)
        {
			for (int i = 0; i < secondText.Length + 1; i++)
			{
				currentText2 = secondText.Substring(0, i);
				secondSelectedText.text = currentText2;
				yield return new WaitForSeconds(delay);
				CheckIfDone();
			}
		}
	}

	private IEnumerator WaitForSecondsShowText()
    {
		yield return new WaitForSeconds(textDelay);
		StartCoroutine(ShowText());

	}
}
