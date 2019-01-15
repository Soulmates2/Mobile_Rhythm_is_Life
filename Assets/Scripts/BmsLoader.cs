using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class BmsLoader : MonoBehaviour
{
    public static string bmsFileName;
    public bool isFinishLoad = false;
    public Bms bms;
    public List<GameObject> objectList;
    public float W;
    public GameObject Note135;
    public GameObject Note24;

    // Start is called before the first frame update
    void Start()
    {
        Note135 = GameObject.Find("NoteCube 135");
        Note24 = GameObject.Find("NoteCube 24");
        objectList = new List<GameObject>(); ;
        bms = gameObject.AddComponent<Bms>();
        BmsLoad();
    }

    private void BmsLoad()
    {
        //bmsFileName = "MINO - anacne.bms";
        W = 40;
        bms = gameObject.AddComponent<Bms>();
        string[] lineData = File.ReadAllLines(pathForFiles(bmsFileName));
        foreach (string line in lineData)
        {
            //Debug.Log(line);
            if (line.StartsWith("#"))
            {
                string[] data = line.Split(' ');

                // exception
                if (data[0].IndexOf(":") == -1 && data.Length == 1)
                {
                    continue;
                }

                // header field
                if (data[0].Equals("#TITLE"))
                {
                    bms.setTitle(data[1]);
                }
                else if (data[0].Equals("#ARTIST"))
                {
                    bms.setArtist(data[1]);
                }
                else if (data[0].Equals("#BPM"))
                {
                    bms.setBpm(double.Parse(data[1]));
                }
                else if (data[0].Equals("#PLAYER"))
                {
                }
                else if (data[0].Equals("#GENRE"))
                {
                }
                else if (data[0].Equals("#PLAYLEVEL"))
                {
                }
                else if (data[0].Equals("#RANK"))
                {
                }
                else if (data[0].Equals("#TOTAL"))
                {
                }
                else if (data[0].Equals("#VOLWAV"))
                {
                }
                else if (data[0].Equals("#MIDIFILE"))
                {
                }
                else if (data[0].Equals("#WAV02"))
                {
                }//
                else if (data[0].Equals("#BMP01"))
                {
                }//
                else if (data[0].Equals("#STAGEFILE"))
                {
                }
                else if (data[0].Equals("#VIDEOFILE"))
                {
                }
                else if (data[0].Equals("#BGA"))
                {
                }
                else if (data[0].Equals("#STOP"))
                {
                }
                else if (data[0].Equals("#LNTYPE"))
                {
                    bms.setLnType(int.Parse(data[1]));
                }
                else if (data[0].Equals("#LNOBJ"))
                {
                }
                else
                {
                    // data field
                    int bar = 0; // node key
                    Int32.TryParse(data[0].Substring(1, 3), out bar);

                    int channel = 0; // node channel
                    Int32.TryParse(data[0].Substring(4, 2), out channel);

                    string noteStr = data[0].Substring(7);
                    List<int> noteData = getNoteDataOfStr(noteStr);

                    Note note = gameObject.AddComponent<Note>();
                    note.setBar(bar);
                    note.setChannel(channel);
                    note.setNoteData(noteData);
                    //note.debug();

                    bms.addNote(note);
                    isFinishLoad = true;
                }
            }
        }
        if (isFinishLoad)
        {
            foreach (Note note in bms.getNoteList())
            {
                switch (note.channel)
                {
                    case 11:
                        int cnt = 0;
                        switch (note.noteData.Count)
                        {
                            case 1:
                                GameObject r_1 = Instantiate(Note135);
                                r_1.transform.position = new Vector3(-10, -15, 30 + note.bar * W);
                                objectList.Add(r_1);
                                break;
                            case 2:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject r_2 = Instantiate(Note135);
                                        r_2.transform.position = new Vector3(-10, -15, 30 + (note.bar * W) + (W / 8 * cnt));
                                        objectList.Add(r_2);
                                    }
                                    cnt += 4;
                                }
                                break;
                            case 4:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject r_4 = Instantiate(Note135);
                                        r_4.transform.position = new Vector3(-10, -15, 30 + (note.bar * W) + (W / 8 * cnt));
                                        objectList.Add(r_4);
                                    }
                                    cnt += 2;
                                }
                                break;
                            case 8:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject r_8 = Instantiate(Note135);
                                        r_8.transform.position = new Vector3(-10, -15, 30 + (note.bar * W) + (W / 8 * cnt));
                                        objectList.Add(r_8);
                                    }
                                    cnt += 1;
                                }
                                break;
                        }
                        break;

                    case 12:
                        int cnt2 = 0;
                        switch (note.noteData.Count)
                        {
                            case 1:
                                GameObject g_1 = Instantiate(Note24);
                                g_1.transform.position = new Vector3(-5, -15, 30 + note.bar * W);
                                objectList.Add(g_1);
                                break;
                            case 2:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_2 = Instantiate(Note24);
                                        g_2.transform.position = new Vector3(-5, -15, 30 + (note.bar * W) + (W / 8 * cnt2));
                                        objectList.Add(g_2);
                                    }
                                    cnt2 += 4;
                                }
                                break;
                            case 4:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_4 = Instantiate(Note24);
                                        g_4.transform.position = new Vector3(-5, -15, 30 + (note.bar * W) + (W / 8 * cnt2));
                                        objectList.Add(g_4);
                                    }
                                    cnt2 += 2;
                                }
                                break;
                            case 8:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_8 = Instantiate(Note24);
                                        g_8.transform.position = new Vector3(-5, -15, 30 + (note.bar * W) + (W / 8 * cnt2));
                                        objectList.Add(g_8);
                                    }
                                    cnt2 += 1;
                                }
                                break;
                        }
                        break;
                    case 13:
                        int cnt3 = 0;
                        switch (note.noteData.Count)
                        {
                            case 1:
                                GameObject g_1 = Instantiate(Note135);
                                g_1.transform.position = new Vector3(0, -15, 30 + note.bar * W);
                                objectList.Add(g_1);
                                break;
                            case 2:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_2 = Instantiate(Note135);
                                        g_2.transform.position = new Vector3(0, -15, 30 + (note.bar * W) + (W / 8 * cnt3));
                                        objectList.Add(g_2);
                                    }
                                    cnt3 += 4;
                                }
                                break;
                            case 4:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_4 = Instantiate(Note135);
                                        g_4.transform.position = new Vector3(0, -15, 30 + (note.bar * W) + (W / 8 * cnt3));
                                        objectList.Add(g_4);
                                    }
                                    cnt3 += 2;
                                }
                                break;
                            case 8:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_8 = Instantiate(Note135);
                                        g_8.transform.position = new Vector3(0, -15, 30 + (note.bar * W) + (W / 8 * cnt3));
                                        objectList.Add(g_8);
                                    }
                                    cnt3 += 1;
                                }
                                break;
                        }
                        break;
                    case 14:
                        int cnt4 = 0;
                        switch (note.noteData.Count)
                        {
                            case 1:
                                GameObject g_1 = Instantiate(Note24);
                                g_1.transform.position = new Vector3(5, -15, 30 + note.bar * W);
                                objectList.Add(g_1);
                                break;
                            case 2:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_2 = Instantiate(Note24);
                                        g_2.transform.position = new Vector3(5, -15, 30 + (note.bar * W) + (W / 8 * cnt4));
                                        objectList.Add(g_2);
                                    }
                                    cnt4 += 4;
                                }
                                break;
                            case 4:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_4 = Instantiate(Note24);
                                        g_4.transform.position = new Vector3(5, -15, 30 + (note.bar * W) + (W / 8 * cnt4));
                                        objectList.Add(g_4);
                                    }
                                    cnt4 += 2;
                                }
                                break;
                            case 8:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_8 = Instantiate(Note24);
                                        g_8.transform.position = new Vector3(5, -15, 30 + (note.bar * W) + (W / 8 * cnt4));
                                        objectList.Add(g_8);
                                    }
                                    cnt4 += 1;
                                }
                                break;
                        }
                        break;
                    case 15:
                        int cnt5 = 0;
                        switch (note.noteData.Count)
                        {
                            case 1:
                                GameObject g_1 = Instantiate(Note135);
                                g_1.transform.position = new Vector3(10, -15, 30 + note.bar * W);
                                objectList.Add(g_1);
                                break;
                            case 2:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_2 = Instantiate(Note135);
                                        g_2.transform.position = new Vector3(10, -15, 30 + (note.bar * W) + (W / 8 * cnt5));
                                        objectList.Add(g_2);
                                    }
                                    cnt5 += 4;
                                }
                                break;
                            case 4:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_4 = Instantiate(Note135);
                                        g_4.transform.position = new Vector3(10, -15, 30 + (note.bar * W) + (W / 8 * cnt5));
                                        objectList.Add(g_4);
                                    }
                                    cnt5 += 2;
                                }
                                break;
                            case 8:
                                foreach (int i in note.noteData)
                                {
                                    if (i == 1)
                                    {
                                        GameObject g_8 = Instantiate(Note135);
                                        g_8.transform.position = new Vector3(10, -15, 30 + (note.bar * W) + (W / 8 * cnt5));
                                        objectList.Add(g_8);
                                    }
                                    cnt5 += 1;
                                }
                                break;
                        }
                        break;
                }

            }
        }
    }
    private List<int> getNoteDataOfStr(string str)
    {
        string tempStr = str;
        List<int> noteList = new List<int>();

        while (true)
        {
            if (tempStr.Length > 2)
            {
                int data = 0;
                Int32.TryParse(tempStr.Substring(0, 2), out data);

                noteList.Add(data);
                tempStr = tempStr.Substring(2);
            }
            else
            {
                int data = 0;
                Int32.TryParse(tempStr, out data);
                noteList.Add(data);
                break;
            }

        }

        // 총노트수 증가
        foreach (int note in noteList)
        {
            if (note != 0)
            {
                bms.sumTotalNoteCount();
            }
        }

        return noteList;
    }

    void Update()
    {
        Double bpm = bms.getBpm();
        //  Debug.Log(HP_Manager.isGameEnd.ToString());
        foreach (GameObject o in objectList)
        {
            if (o != null) o.transform.position += new Vector3(0f, 0f, 20 * Time.deltaTime * (float)(-0.5) * (float)bpm / 60);
          /*  if (HP_Manager.isGameEnd)
            {
                Debug.Log("Hp 0 game end");
                Destroy(this);
            }*/
        }
    }
    public string pathForFiles(string filename)
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            string path = Application.persistentDataPath;
            return Path.Combine(path, filename);
        }
        else
        {
           string path = Application.dataPath;

            return Path.Combine(path, filename);
        }
    }
}
