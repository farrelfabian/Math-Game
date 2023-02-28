using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Math_Add : MonoBehaviour
{
    int firstNumber, secondNumber, tempNumber, finalAns, Answer1, Answer2, Answer3;
    public Text FirstDigit, SecondDigit, Operation, Ans1, Ans2, Ans3, Ans4, CorrectAns;
    public Sprite SpriteTrue, SpriteFalse, SpriteTrans; 
    private string VarOperation;
    public GameObject True_or_False_1, True_or_False_2, True_or_False_3, True_or_False_4;
    public GameObject GameOver, Prob;
    public GameObject A1, A2, A3, A4;
    
    private int Skor_Add, HSkor_Add;
    public Text SkorKu_Add, SkorKuF_Add, HSkorKu_Add;

    public Text TextTimer;
    public float Waktu;
    float s;
    public bool GameAktif = true;
    public bool timerActive = false;

    [SerializeField] private TextWriter textWriter;
    private Text msgText;

    private void Awake()
    {
        msgText = GameObject.Find("msgText").GetComponent<Text>();
    }

    // Start is called before the first frame update
    void Start(){
        Skor_Add = 0;
        SkorKu_Add.text = "Skor : " + Skor_Add;
        
        textWriter.AddWriter(msgText, "Sudah siap menjawab soal penjumlahan ?", .1f, true);
    }

    // Update is called once per frame
    void Update(){
        Timer();
        SetText();
    }

    public void FuncAdd(){
        Problem("addition");
        Prob.SetActive(true);
        timerActive = !timerActive;
        Reset();
    }

    public void Problem(string operation){
        ResetNumber();

        firstNumber = Random.Range(1,30);
        secondNumber = Random.Range(1,40);

        if(firstNumber-secondNumber < 0){
            tempNumber = secondNumber;
            secondNumber = firstNumber;
            firstNumber = tempNumber;
        }

        if(operation == "addition"){
            finalAns = firstNumber + secondNumber;
            VarOperation = "addition";
        }

        FirstDigit.text = firstNumber.ToString();
        SecondDigit.text = secondNumber.ToString();

        if(VarOperation == "addition"){
            Operation.text = "+";
        }
         
        //Random Answer 
        tempNumber = Random.Range(2, 70);
        while(tempNumber == finalAns){
            tempNumber = Random.Range(2,70);
        }
        Answer1 = tempNumber;

        tempNumber = Random.Range(2, 50);
        while((tempNumber == finalAns) || (tempNumber == Answer1)){
            tempNumber = Random.Range(2,50);
        }
        Answer2 = tempNumber;

        tempNumber = Random.Range(2, 30);
        while((tempNumber == finalAns) || (tempNumber == Answer1) || (tempNumber == Answer2)){
            tempNumber = Random.Range(2,30);
        }
        Answer3 = tempNumber;

        Debug.Log(firstNumber + " + " + secondNumber + " = " + finalAns);
        Debug.Log("Answ : " + Answer1 + " - " + Answer2 + " - "+ Answer3 + " - "+ finalAns);

        
        //Random Answer Position
        tempNumber = Random.Range(1, 8);
        if(tempNumber == 1){
            Ans1.text = finalAns.ToString(); Ans2.text = Answer1.ToString(); Ans3.text = Answer2.ToString(); Ans4.text = Answer3.ToString();
        }

        if(tempNumber == 2){
            Ans1.text = finalAns.ToString(); Ans2.text = Answer3.ToString(); Ans3.text = Answer1.ToString(); Ans4.text = Answer2.ToString();
        }

        if(tempNumber == 3){
            Ans1.text = Answer1.ToString(); Ans2.text = finalAns.ToString(); Ans3.text = Answer3.ToString(); Ans4.text = Answer2.ToString();
        }

        if(tempNumber == 4){
            Ans1.text = Answer2.ToString(); Ans2.text = finalAns.ToString(); Ans3.text = Answer1.ToString(); Ans4.text = Answer3.ToString();
        }

        if(tempNumber == 5){
            Ans1.text = Answer3.ToString(); Ans2.text = Answer2.ToString(); Ans3.text = finalAns.ToString(); Ans4.text = Answer1.ToString();
        }

        if(tempNumber == 6){
            Ans1.text = Answer1.ToString(); Ans2.text = Answer3.ToString(); Ans3.text = finalAns.ToString(); Ans4.text = Answer2.ToString();
        }

        if(tempNumber == 7){
            Ans1.text = Answer2.ToString(); Ans2.text = Answer3.ToString(); Ans3.text = Answer1.ToString(); Ans4.text = finalAns.ToString();
        }

        if(tempNumber == 8){
            Ans1.text = Answer1.ToString(); Ans2.text = Answer2.ToString(); Ans3.text = Answer3.ToString(); Ans4.text = finalAns.ToString();
        }
    }

    //Action if answer true or flase
    public void Ans1_act(){
        if(Ans1.text == finalAns.ToString()){
            True_or_False_1.GetComponent<Image>().sprite = SpriteTrue;
            Correct();
        }
        else{
            True_or_False_1.GetComponent<Image>().sprite = SpriteFalse;
            A1.SetActive(false);
            Wrong();
        }
    }

    public void Ans2_act(){
        if(Ans2.text == finalAns.ToString()){
            True_or_False_2.GetComponent<Image>().sprite = SpriteTrue;
            Correct();
        }
        else{
            True_or_False_2.GetComponent<Image>().sprite = SpriteFalse;
            A2.SetActive(false);
            Wrong();
        }
    }

    public void Ans3_act(){
        if(Ans3.text == finalAns.ToString()){
            True_or_False_3.GetComponent<Image>().sprite = SpriteTrue;
            Correct();
        }
        else{
            True_or_False_3.GetComponent<Image>().sprite = SpriteFalse;
            A3.SetActive(false);
            Wrong();
        }
    }

    public void Ans4_act(){
        if(Ans4.text == finalAns.ToString()){
            True_or_False_4.GetComponent<Image>().sprite = SpriteTrue;
            Correct();
        }
        else{
            True_or_False_4.GetComponent<Image>().sprite = SpriteFalse;
            A4.SetActive(false);
            Wrong();
        }
    }

    public void ResetNumber(){
        CorrectAns.text = "?";
        True_or_False_1.GetComponent<Image>().sprite = SpriteTrans;
        True_or_False_2.GetComponent<Image>().sprite = SpriteTrans;
        True_or_False_3.GetComponent<Image>().sprite = SpriteTrans;
        True_or_False_4.GetComponent<Image>().sprite = SpriteTrans;
        A1.SetActive(true);
        A2.SetActive(true);
        A3.SetActive(true);
        A4.SetActive(true);
    }

    public void Reset(){
        Skor_Add = 0;
        SkorKu_Add.text = "Skor : " + Skor_Add;
    }
    
    public void Correct(){
        CorrectAns.text = finalAns.ToString();
        Skor_Add += 1;
        SkorKu_Add.text = "Skor : " + Skor_Add;
        StartCoroutine(NewQuestion());
    }

    public void Wrong(){
        Skor_Add -= 1;
        SkorKu_Add.text = "Skor : " + Skor_Add;
    }

    IEnumerator NewQuestion(){
        yield return new WaitForSeconds(0.3f);
        Problem(VarOperation);
    }

    void SetText(){
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
        TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
    }

    private void Timer(){
        if(timerActive){
            if(GameAktif){
                s += Time.deltaTime;
                if(s >= 1){
                    Waktu--;
                    s = 0;
                }
            }

            if(GameAktif && Waktu <= 0){
                GameOver.SetActive(true);
                Prob.SetActive(false);
                SkorKuF_Add.text = "Skor : " + Skor_Add;
                if(Skor_Add >= PlayerPrefs.GetInt("HSkor_Add"))
                {
                    PlayerPrefs.SetInt("HSkor_Add", Skor_Add);
                }
                HSkorKu_Add.text = "High Skor : " + PlayerPrefs.GetInt("HSkor_Add");

                GameAktif = false;
            }
        }
    }
}
