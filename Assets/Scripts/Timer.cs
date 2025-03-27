using System.Threading;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float duration = 0;
    private float elapsedTime = 0;
    private bool started = false;
    private bool running = false;

    // Update is called once per frame
    void Update()
    {
        if (running) {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= duration)
            {
                running = false;
                elapsedTime = 0;
            }

        }
    }

    public void run() {
        if(duration > 0)
        {
           started = true;
           running = true;
           elapsedTime = 0;
        }
    }
    public float Duration { set {if (!running) duration = value;}}
   public bool Finished { get {return started && !running;} }
   public bool isRunning { get { return running; }}
}
