using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;


public class Tasks : MonoBehaviour
{
    [SerializeField] private List<Task> taskList = new List<Task>();
    [SerializeField] private Button randomizeButton;

    // [SerializeField] private List<string> chosenTasks = new List<string>();
    [SerializeField] private List<Text> taskText = new List<Text>();
    private System.Random rnd = new System.Random();

    [System.Serializable]
    public class Task
    {
        public List<string> tasks = new List<string>();
    }

    void Start()
    {
        FillTasks();
        ChooseTasks();
        randomizeButton.onClick.AddListener(ChooseTasks);
    }

    private void FillTasks()
    {
        Task brightnessTask = new Task();
        brightnessTask.tasks.Add("Increase the brightness of the room");
        brightnessTask.tasks.Add("Decrease the brightness of the room");
        taskList.Add(brightnessTask);

        Task videoTask = new Task();
        videoTask.tasks.Add("Change the video to \"Never Gonna Give You Up\"");
        videoTask.tasks.Add("Change the video to \"Monkey\"");
        videoTask.tasks.Add("Change the video to \"Levan Polkka\"");
        videoTask.tasks.Add("Change the video to \"Rasputin\"");
        videoTask.tasks.Add("Change the video to \"Macarena\"");
        taskList.Add(videoTask);

        Task volumeTask = new Task();
        volumeTask.tasks.Add("Increase the volume of the TV");
        volumeTask.tasks.Add("Decrease the volume of the TV");
        taskList.Add(volumeTask);

        Task hideTask = new Task();
        hideTask.tasks.Add("Hide the cube");
        hideTask.tasks.Add("Hide the doll");
        hideTask.tasks.Add("Hide the chess piece");
        hideTask.tasks.Add("Hide the mug");
        taskList.Add(hideTask);

        Task resizeTask = new Task();
        resizeTask.tasks.Add("Make the cube bigger");
        resizeTask.tasks.Add("Make the cube smaller");
        resizeTask.tasks.Add("Make the mug bigger");
        resizeTask.tasks.Add("Make the mug smaller");
        resizeTask.tasks.Add("Make the doll bigger");
        resizeTask.tasks.Add("Make the doll smaller");
        resizeTask.tasks.Add("Make the chess piece bigger");
        resizeTask.tasks.Add("Make the chess piece smaller");
        taskList.Add(resizeTask);

        Task moveTask = new Task();
        moveTask.tasks.Add("Move to the other room behind TV and pick up the object");
        taskList.Add(moveTask);


    }

    public void ChooseTasks()
    {
        int[] indexArray = GetIndices(taskList.Count);
        
        
        for (int i = 0; i < taskList.Count; i++)
        {
            Task task = taskList[i];
            int index = GetIndex(task.tasks.Count);
            taskText[indexArray[i]].text = task.tasks[index];
        }     

    }

    private int GetIndex(int limit)
    {  
        return rnd.Next(limit);
    }

    private int[] GetIndices(int limit)
    {
        HashSet<int> indices = new HashSet<int>();
        while(indices.Count < limit)
        {
            indices.Add(rnd.Next(limit));
        }

        int[] indexArray = new int[limit];
        indices.CopyTo(indexArray);

        return indexArray;
    }
}
