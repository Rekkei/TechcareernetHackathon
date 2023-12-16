using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Quiz : MonoBehaviour
{
    [Header("Questions")]
    [SerializeField] TextMeshProUGUI questionText;
    [SerializeField] List<QuestionSO> questions = new List<QuestionSO>();
    QuestionSO currentQuestion;

    [Header("Answers")]
    [SerializeField] GameObject[] answerButtons;
    int correctAnswerIndex;
    bool hasAnsweredEarly;

    [Header("Animator")]
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;
    [SerializeField] Animator strangeGuy;

    void Start()
    {
        GetNextQuestion();
    }

    void Update()
    {
        if (hasAnsweredEarly)
        {
            strangeGuy.SetBool("isAnswered", true);
            StartCoroutine(ResetAnimation());

        }
    }

    IEnumerator ResetAnimation()
    {
        audioSource.PlayOneShot(audioClip);
        hasAnsweredEarly = false;
        yield return new WaitForSeconds(5);

        strangeGuy.SetBool("isAnswered", false);
        GetNextQuestion();
    }

    public void OnAnswerSelected()
    {
        hasAnsweredEarly = true;
    }

    void GetNextQuestion()
    {
        if (questions.Count > 0)
        {
            GetRandomQuestion();
            DisplayQuestion();
        }
    }

    void GetRandomQuestion()
    {
        int index = Random.Range(0, questions.Count);
        currentQuestion = questions[index];

        if (questions.Contains(currentQuestion))
        {
            questions.Remove(currentQuestion);
        }
    }

    void DisplayQuestion()
    {
        questionText.text = currentQuestion.GetQuestion();

        for (int i = 0; i < answerButtons.Length; i++)
        {
            TextMeshProUGUI buttonText = answerButtons[i].GetComponentInChildren<TextMeshProUGUI>();
            buttonText.text = currentQuestion.GetAnswer(i);
        }
    }
}
