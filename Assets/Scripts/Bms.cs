using UnityEngine;
using System.Collections;
using System.Collections.Generic;
 
public class Bms : MonoBehaviour {
 
    public string title;        // 타이틀
    public string artist;       // 아티스트
    public double bpm;          // BPM
    public List<Note> noteList; // 노트 데이터 리스트
    public int totalNoteCount;  // 총 노트수
    public int lnType;          // 롱노트 타입
 
    void Awake()
    {
        title = "";
        artist = "";
        bpm = 0;
        noteList = new List<Note>();
        totalNoteCount = 0;
        lnType = 0;
    }
 
    // get/set
    public string getTitle()
    {
        return title;
    }
    public void setTitle(string title)
    {
        this.title = title;
    }
    public string getArtist()
    {
        return artist;
    }
    public void setArtist(string artist)
    {
        this.artist = artist;
    }
    public List<Note> getNoteList()
    {
        return noteList;
    }
    public void setNoteList(List<Note> noteList)
    {
        this.noteList = noteList;
    }
    public double getBpm()
    {
        return bpm;
    }
    public void setBpm(double bpm)
    {
        this.bpm = bpm;
    }
    public int getTotalNoteCount()
    {
        return totalNoteCount;
    }
    public void setTotalNoteCount(int totalCount)
    {
        this.totalNoteCount = totalCount; ;
    }
    public int getLnType()
    {
        return lnType;
    }
    public void setLnType(int lnType)
    {
        this.lnType = lnType; ;
    }
 
    // add
    public void addNote(Note note)
    {
        noteList.Add(note);
    }
 
    // sum
    public void sumTotalNoteCount()
    {
        this.totalNoteCount++;
    }
 
    // debug
    public void debug()
    {
        print("title = " + title);
        print("artist = " + artist);
        print("bpm = " + bpm);
        print("noteList = " + noteList.Count);
        print("totalNoteCount = " + totalNoteCount);
        print("lnType = " + lnType);
    }
 
}