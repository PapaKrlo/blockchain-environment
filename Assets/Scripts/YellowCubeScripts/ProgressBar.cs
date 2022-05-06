using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class ProgressBar : FillBar {

    // Event to invoke when the progress bar fills up
    private UnityEvent onProgressComplete;
    public float speed = 0.0003f;
    private bool clicked = false;
    
    private int count = 0;
    

    public Text counterText;

    // Create a property to handle the slider's value
    public new float CurrentValue {
        get {
            return base.CurrentValue;
        }
        set {
            // If the value exceeds the max fill, invoke the completion function
            if (value >= slider.maxValue)
                onProgressComplete.Invoke();

            // Remove any overfill (i.e. 105% fill -> 5% fill)
            base.CurrentValue = value % slider.maxValue;
        }
    }
    
    void Start () {
        // Initialize onProgressComplete and set a basic callback
        if (onProgressComplete == null)
            onProgressComplete = new UnityEvent();
        onProgressComplete.AddListener(OnProgressComplete);
    }
	
    void Update () {
        if(clicked){
            CurrentValue += speed;
            counterText.text = count.ToString();
        }
    }

    // The method to call when the progress bar fills up
    void OnProgressComplete() {
        count+=1;
        //countRabbit+=1;

        Debug.Log("Progress Complete");
    }
    public void startClick(){
        clicked = true;
    }
}