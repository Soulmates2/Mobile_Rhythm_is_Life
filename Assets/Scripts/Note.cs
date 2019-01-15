using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class Note : MonoBehaviour {
 
    public int bar;             // 마디 넘버
    public int channel;         // 채널 넘버
    public List<int> noteData;  // 노트 정보
 
    void Awake() // called when created
    {
        bar = 0;
        channel = 0;
        noteData = new List<int>();
    }
 
    public int getBar()
    {
        return bar;
    }
    public void setBar(int bar)
    {
        this.bar = bar;
    }
    public int getChannel()
    {
        return channel;
    }
    public void setChannel(int channel)
    {
        this.channel = channel;
    }
    public List<int> getNoteData()
    {
        return noteData;
    }
    public void setNoteData(List<int> noteData)
    {
        this.noteData = noteData;
    }
 
    // debug
    public void debug()
    {
        print("bar = " + bar);
        print("channel = " + channel);
        foreach (int note in noteData)
        {
            print("note = " + note);
        }
    }
}