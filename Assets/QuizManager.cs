using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject questionAndAnswerPanel;
    public GameObject endPanel;
    public GameObject moneyPanel;
    public GameObject nickPanel;
    public GameObject startButton;
    public GameObject gameButtons;
    public Timer timer;

    public string playerName;
    public QuestionRepository questionRepository;
    public GameObject[] answerButtons;
    public QuestionAndAnswer currentQuestion;
    public TMP_Text questionDisplay;
    public TMP_Text timerText;

    public int level = 0;
    int[] prize = { 0, 500, 1000, 2000, 5000, 10000, 20000, 50000, 75000, 150000, 250000, 500000, 1000000 };

    private void Start()
    {
        questionRepository = new QuestionRepository();
        ShowStartPanel();
    }

    void ShowStartPanel()
    {
        startPanel.SetActive(true);
        questionAndAnswerPanel.SetActive(false);
        endPanel.SetActive(false);

        timerText.text = "";
        TMP_Text nameText = nickPanel.transform.Find("NameText").GetComponent<TMP_Text>();
        nameText.text = "Wpisz jaka nazwa ma być wyświetlana:";
        nameText.color = Color.white;
        timer.ResetText();
    }

    void ShowQuestionAndAnswerPanel()
    {
        startPanel.SetActive(false);
        questionAndAnswerPanel.SetActive(true);
        endPanel.SetActive(false);

        timerText.text = "60s";

        ShowNextQuestionButton(false);
        HideFriendPanel();
    }

    void ShowEndPanel()
    {
        startPanel.SetActive(false);
        questionAndAnswerPanel.SetActive(true);
        endPanel.SetActive(true);

        HideFriendPanel();
    }

    public void StartGame()
    {
        if (playerName != "")
        {
            ShowQuestionAndAnswerPanel();
            GenerateQuestion();
        }
        else
        {
            TMP_Text nameText = nickPanel.transform.Find("NameText").GetComponent<TMP_Text>();
            nameText.text = "Musisz wpisać chociaż 1 znak!";
            nameText.color = Color.red;
        }

    }

    public void SetPlayerName(string name)
    {
        playerName = name;
    }

    void GenerateQuestion()
    {
        currentQuestion = questionRepository.GetRandomQuestion(level);
        questionDisplay.text = currentQuestion.question;

        SetAnswers();
        timer.StartTimer();
    }

    void SetAnswers()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponent<AnswerScript>().isCorrect = false;
            answerButtons[i].transform.GetChild(0).GetComponent<TMP_Text>().text = currentQuestion.answers[i];
            answerButtons[i].GetComponent<Image>().color = answerButtons[i].GetComponent<AnswerScript>().startColor;

            if (currentQuestion.correctAnswer == i + 1)
            {
                answerButtons[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    public void NextQuestion()
    {
        GenerateQuestion();
        EnableButtons();

        ShowNextQuestionButton(false);
        HideFriendPanel();
        RepairFiftyFifty();
    }

    void DissableButtons()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponent<Button>().interactable = false;
        }
    }

    void EnableButtons()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].GetComponent<Button>().interactable = true;
        }
    }

    public void CorrectAnswer()
    {
        
        level++;
        UpdateMoneyPanel();
        DissableButtons();
        if (level == 12)
        {
            WinGame();
        }
        else
        {
            timer.StopTimer();
            ShowNextQuestionButton(true);
        }
    }

    public void WinGame()
    {
        GameOver(false);
    }

    public void WrongAnswer()
    {
        int correctAnswer = currentQuestion.correctAnswer;

        answerButtons[correctAnswer - 1].GetComponent<Image>().color = Color.green;

        GameOver(true);
    }

    public void GameOver(bool lost)
    {
        timer.StopTimer();
        ShowEndPanel();

        if (lost)
        {
            TMP_Text endText = endPanel.transform.Find("Panel2/EndText").GetComponent<TMP_Text>();
            TMP_Text scoreText = endPanel.transform.Find("Panel1/ScoreText").GetComponent<TMP_Text>();

            endText.text = "Przegrałeś, " + playerName + "!";
            int prizeLevel = 0;
            if (level < 2) prizeLevel = 0;
            else if (level < 7) prizeLevel = 2;
            else if (level < 12) prizeLevel = 7;
            else prizeLevel = 12;
            scoreText.text = "Twój wynik: " + prize[prizeLevel] + " zł";
        }
        else
        {
            TMP_Text endText = endPanel.transform.Find("Panel2/EndText").GetComponent<TMP_Text>();
            TMP_Text scoreText = endPanel.transform.Find("Panel1/ScoreText").GetComponent<TMP_Text>();

            int adjustedLevel = level;
            if (level == 12) adjustedLevel = 11;
            int correctAnswer = currentQuestion.correctAnswer;
            answerButtons[correctAnswer - 1].GetComponent<Image>().color = Color.green;

            endText.text = "Wygrałeś, " + playerName + "!";
            scoreText.text = "Twój wynik: " + prize[level] + " zł";

        }

    }

    public void RestartGame()
    {
        level = 0;
        timer.StopTimer();
        timer.ResetText();
        ResetMoneyPanel();
        ShowStartPanel();

        EnableSpecialButtons(true);
        RepairFiftyFifty();
    }

    public void UpdateMoneyPanel()
    {
        GameObject previousPanel = null;
        if (level - 1 > 0)
        {
            previousPanel = moneyPanel.transform.Find("Panel" + (level - 1)).gameObject;
        }
        GameObject currentPanel = moneyPanel.transform.Find("Panel" + level).gameObject;

        if (previousPanel != null && (level == 3 || level == 8 || level == 13))
        {
            previousPanel.GetComponent<Image>().color = new Color(65 / 255.0f, 76 / 255.0f, 243 / 255.0f);
        }
        else if (previousPanel != null)
        {
            previousPanel.GetComponent<Image>().color = new Color(0 / 255.0f, 10 / 255.0f, 164 / 255.0f);
        }
        currentPanel.GetComponent<Image>().color = new Color(0, 255, 0);
    }

    void ResetMoneyPanel()
    {
        for (int i = 0; i < moneyPanel.transform.childCount; i++)
        {
            if (i == 1 || i == 6 || i == 11)
            {
                moneyPanel.transform.GetChild(i).GetComponent<Image>().color = new Color(65 / 255.0f, 76 / 255.0f, 243 / 255.0f);
            }
            else
            {
                moneyPanel.transform.GetChild(i).GetComponent<Image>().color = new Color(0 / 255.0f, 10 / 255.0f, 164 / 255.0f);
            }
        }
    }

    void ShowNextQuestionButton(bool show)
    {
        GameObject nextQuestionButton = questionAndAnswerPanel.transform.Find("NextQuestionButton").gameObject;
        nextQuestionButton.SetActive(show);
    }

    void EnableFriendButton(bool enable)
    {
        GameObject friendButton = gameButtons.transform.Find("CallFriend").gameObject;
        friendButton.GetComponent<Button>().interactable = enable;
    }

    void EnableFiftyFiftyButton(bool enable)
    {
        GameObject fiftyFiftyButton = gameButtons.transform.Find("5050").gameObject;
        fiftyFiftyButton.GetComponent<Button>().interactable = enable;
    }

    void EnableSpecialButtons(bool enable)
    {
        EnableFriendButton(enable);
        EnableFiftyFiftyButton(enable);
    }

    public void ShowFriendPanel()
    {
        GameObject friendPanel = questionAndAnswerPanel.transform.Find("FriendPanel").gameObject;
        friendPanel.SetActive(true);

        TMP_Text friendText = friendPanel.transform.Find("FriendText").GetComponent<TMP_Text>();
        friendText.text = "Hmm, wydaje mi się, że odpowiedź to: " + currentQuestion.answers[currentQuestion.correctAnswer - 1];

        EnableFriendButton(false);
    }

    void HideFriendPanel()
    {
        GameObject friendPanel = questionAndAnswerPanel.transform.Find("FriendPanel").gameObject;
        friendPanel.SetActive(false);
    }

    public void FiftyFifty()
    {
        int correctAnswer = currentQuestion.correctAnswer;
        int wrongAnswer = 0;

        do
        {
            wrongAnswer = Random.Range(1, 5);
        } while (wrongAnswer == correctAnswer);

        for (int i = 0; i < answerButtons.Length; i++)
        {
            if (i + 1 == correctAnswer || i + 1 == wrongAnswer)
            {
                continue;
            }
            else
            {
                answerButtons[i].SetActive(false);
            }
        }

        EnableFiftyFiftyButton(false);
    }

    void RepairFiftyFifty()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].SetActive(true);
        }
    }

}
