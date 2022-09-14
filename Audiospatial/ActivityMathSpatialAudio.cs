using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;


namespace Audiospatial
{

    class ActivityMathSpatialAudio
    {
        private readonly Main form;
        private readonly Activity_Stanza activity;
        private readonly Speakers speakers;
        private readonly debugInfo debug;
        private readonly ucSpeaker ucs;
        private readonly Activities available_activities;

        private SingleActivity currActivity;
        private SingleActivity[] chosenActivities;

        private int iDifficultyLevel = 0;
        private int iType = 0;
        private int iParticipants = 5;
        private string group = "";
        private string k;

        private ActivityResult results;

        private static readonly string[] speaker_labels = new string[] { "L", "B", "R" };     // west, north, east

        private static readonly string[] operations_symbols = new string[] { "dog", "cat", "lion", "chewbacca" };
        private static readonly string[] operations_labels = new string[] { "+", "-", "x", "/" };
        private readonly List<string> currOperationsLabels = new List<string>(); // displayed labels of the operations
        private readonly List<string> currOperationsSymbols = new List<string>(); // displayed symbols of the operations

        private static System.Windows.Forms.Timer aTimer;
        private const string TAG_SOUND = "sound";   // identifier of the type of active timer
        private const string TAG_TIMER = "timer";

        public static int N_TYPE_SPATIAL = 0;
        public static int N_TYPE_ASSOCIATIVE = 1;

        private const int N_OP_PLUS = 0;
        private const int N_OP_SUBTRACT = 1;
        private const int N_OP_MULT = 2;
        private const int N_OP_DIVISION = 3;

        private const int sound_interval = 1500;
        private const int timer_interval = 1000;


        private readonly static int[] answerTime = new int[3] { 5, 5, 5 };

        private int currParticipant = -1;   // index of the current participant [0 -> activity's NOP]
        private int currOp = -1;   // index of the current operation [0 -> activity's NOP]
        private int totOps = -1;   // tot number of operation for each participant

        private int currSpeaker = 0;    // speaker used by current operation [0,1,2]
        private int currOperator = 0;    // which operator is applied in the currSpeaker/currOp [0,1,2,3]
        private int currOperand = 0;    // which number reproduce [1->X]

        private int currResult = 0;    // results of the current operation
        private string currResultFile = "";   // fullpath of the current results file

        private int currSound = 0;    // num of sound reproduced [1->currOperand]

        private int elapsedTime = 0;
        public int final_value;
     
        public ActivityMathSpatialAudio(Activities activities, Main form, Speakers speakers, Activity_Stanza activity, debugInfo debug, ucSpeaker ucs)
        {
            this.available_activities = activities;
            this.form = form;
            this.speakers = speakers;
            this.activity = activity;
            this.debug = debug;
            this.ucs = ucs;
    }
        public void init(int diff, int type, int num_participants, string group)
        {
            iDifficultyLevel = diff;
            iType = type;
            iParticipants = num_participants;
            this.group = group;

            currParticipant = -1;

            int num_available_operations = available_activities.items[diff].Count;
            int[] selected_ops = pickRandomSubsequence(num_participants, num_available_operations);

            // select num partipants random activities
            chosenActivities = new SingleActivity[num_participants];
            for (int a = 0; a < num_participants; a++)
                chosenActivities[a] = available_activities.items[diff][selected_ops[a]];

            nextParticipant();
        }

        private void nextParticipant()
        {
            currParticipant++;

            if (currParticipant == iParticipants)
            {
                form.ripetiz = 0;
                if(form.onactivity == 2 && form.ripetiz == 0)
                {
                    form.messaggio = 2;
                    form.onStartActivity(form.iDifficulty, 0, form.participants, "1");
                }
               else if (form.onactivity == 3 && form.ripetiz == 0)
                {
                    form.messaggio = 3;
                    form.onStartActivity(form.iDifficulty, 0, form.participants, "1");
                }
                else if (form.onactivity == 4 && form.ripetiz == 0)
                {
                    form.messaggio = 4; // Questo per il messaggio da mandare in show message  
                    form.onStartActivity(form.iDifficulty, 0, form.participants, "1");
                }
                else if (form.onactivity == 5 && form.ripetiz == 0)
                {
                    form.messaggio = 5; // Questo per il messaggio da mandare in show message 
                    form.onStartActivity(form.iDifficulty, 0, form.participants, "1");
                }
                else if (form.onactivity == 6 && form.ripetiz == 0)
                {
                    form.messaggio = 6; // Questo per il messaggio da mandare in show message  
                    form.onStartActivity(form.iDifficulty, 0, form.participants, "1");
                }
                else if (form.onactivity == 7 && form.ripetiz == 0)
                {
                    form.messaggio = 7; // Questo per il messaggio da mandare in show message  
                    form.finale();

                }
                if (form.ripetiz == 1)
                {
                    form.closeMessage1();
                }
                //  form.onEndActivities();     // LUDA FINISHED !!!!
                return;
            }

            else if (currParticipant == 0)
                onEndParticipant();         // FIRST PARTICIPANT !!!!
            else if (currParticipant < iParticipants)
            {
                form.piu_partecipanti();
               
            }
        }

        private void onEndParticipant()
        {

            if (iType == N_TYPE_SPATIAL)
                form.showMessage("BENVENUTO !!! SEI PRONTO AD IMPARARE LA MATEMATICA !", "comincia", resumeParticipant);
            //else
            //resumeParticipant();
            //form.showAssSoundInfo(iDifficultyLevel, resumeParticipant);
        }

        public void resumeParticipant()
        {

            form.Refresh();

            currActivity = chosenActivities[currParticipant];
            totOps = currActivity.speaker.Length;

            initResultFile(iDifficultyLevel, iType, currParticipant, group, currActivity.id);
            applyActivity(currActivity);

            // start game
            nextOperand();
        }

        private void applyActivity(SingleActivity act)
        {
            currOp = -1;
            currResult = currActivity.start_number;
            activity.applyActivity(act, iType, debug);

            currOperationsLabels.Clear();
            foreach (int op in currActivity.operations)
                currOperationsLabels.Add(operations_labels[op]);    // contains the operators' labels of the three speakers

            currOperationsSymbols.Clear();
            foreach (int op in currActivity.operations)
                currOperationsSymbols.Add(operations_symbols[op]);    // contains the operators' symbols used in the current SingleActivity
        }

        // the same participant starts a new operation
        public void nextOperand()
        {
            currOp++;

            if (currOp == totOps)
            {
                ucs.value_lbl = currResult;
                nextParticipant();
                return;
            }
            int oldNumber = currResult;

            currSpeaker = currActivity.speaker[currOp];     // 0-2
            currOperand = currActivity.operands[currOp];    // 1-N

            currOperator = currActivity.operations[currSpeaker];  // 0-3

            switch (currOperator)
            {
                case N_OP_PLUS:
                    currResult += currOperand;
                    break;

                case N_OP_SUBTRACT:
                    currResult -= currOperand;
                    break;

                case N_OP_MULT:
                    currResult *= currOperand;
                    break;

                case N_OP_DIVISION:
                    currResult /= currOperand;
                    break;
            }

            debug.nextOperand();                            // clear debug and visible true
            activity.nextOperand(oldNumber, currResult);    // show past results (current starting number) and reset counter

            Thread.Sleep(3000);

            activity.setStartNumber(-1);                // ISSUE : cannot hide current starting number
            debug.setDebugInfo(oldNumber.ToString(), currOperationsLabels[currSpeaker], currOperand.ToString(), currResult.ToString());

            if (iType == N_TYPE_SPATIAL) playNsounds(speaker_labels[currSpeaker]);
            else playNsounds(currOperationsSymbols[currSpeaker]);

        }

        //playback first sound and start timer
        private void playNsounds(string source)
        {
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Tick += new EventHandler(TimerEventProcessor);

            aTimer.Interval = sound_interval;
            aTimer.Tag = TAG_SOUND;
            aTimer.Start();
            currSound = 1;
            if (iType == N_TYPE_SPATIAL) speakers.play(source);
            else form.playbackResourceAudio(source);
        }

        // start countdown timer
        private void StartTimer(int rate, int duration)
        {

                        aTimer = new System.Windows.Forms.Timer();
                        aTimer.Tick += new EventHandler(TimerEventProcessor);

                        aTimer.Interval = rate * timer_interval;
                        aTimer.Tag = TAG_TIMER;
                       aTimer.Start();
                        elapsedTime = 4;
           activity.setCountDown((0));
            activity.setCountDown((duration - elapsedTime)); //duration-elapsedTime

           
        }

        // callback of every timer
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
            {
            aTimer.Stop();

            switch (((System.Windows.Forms.Timer)(myObject)).Tag)
            {
                case TAG_SOUND:

                    if (currSound < currOperand)
                    {
                        //SystemSounds.Exclamation.Play();
                        if (iType == N_TYPE_SPATIAL) speakers.play(speaker_labels[currSpeaker]);
                        else form.playbackResourceAudio(currOperationsSymbols[currSpeaker]);
                       // Thread.Sleep(1000);
                        currSound++;
                        aTimer.Start();
                    }
                    else
                        StartTimer(1, answerTime[iDifficultyLevel]);
                    break;

                case TAG_TIMER:

                    elapsedTime++;
                    if (elapsedTime > answerTime[iDifficultyLevel])
                    {
                        form.onCountDownEnd();
                        activity.setCountDown(-1);
                    }
                    else
                    {
                        activity.setCountDown((answerTime[iDifficultyLevel] - elapsedTime));
                        aTimer.Enabled = true;
                    }
                    break;
            }
        }

        // calculate result and write to disk
        public bool isCorrect(int res)
        {
            bool isCorrect = (res == currResult);
            results.results[currOp] = isCorrect;

            using (StreamWriter file = File.CreateText(Main.resultsDir + "\\" + currResultFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, results);
            }

            return isCorrect;
        }

        // init result object and write it to disk
        private void initResultFile(int diff, int type, int num_participants, string group, int activity_id)
        {
            results = new ActivityResult
            {
                participant_id = num_participants,
                type = type,
                group = group,
                difficulty = diff,
                date = DateTime.Now,
                activity_id = activity_id,
                results = new bool[currActivity.operands.Length]
            };

            currResultFile = results.getFileName();
        }

        public static int[] pickRandomSubsequence(int needed_numbers, int tot_numbers)
        {
            int[] array = new int[tot_numbers];
            int[] out_array = new int[needed_numbers];

            for (int n = 0; n < tot_numbers; n++) array[n] = n;
            var rng = new Random();
            rng.Shuffle(array);

            for (int n = 0; n < needed_numbers; n++) out_array[n] = array[n];

            return out_array;
        }
    }



}
    public class SingleActivity
    {
        public int id { get; set; }
        public int difficulty { get; set; }
        public int start_number { get; set; }

        public int[] speaker { get; set; }      // [NOP] : define which speaker must play
                                                // following the speaker_labels      = new string[] { "02", "03", "04"};
                                                //                                          => 0: west, 1: north, 2: east

     public int[] operands { get; set; }     // [NOP] : define which numbers must be manipulated

     public int[] operations { get; set; }   // [3] : define which operation stand in each of the three speaker ( +,-,*,/)
                                                // used to fill:  foreach (int op in currActivity.operations) currOperationsLabels.Add(operations_labels[op]);
    }

    class Activities
    {
        public List<List<SingleActivity>> items { get; set; }
    }
    class ActivityResult
    {
        public int difficulty { get; set; }
        public int type { get; set; }
        public int participant_id { get; set; }
        public string group { get; set; }
        public DateTime date { get; set; }
        public int activity_id { get; set; }
        public bool[] results { get; set; }

        public string getFileName()
        {
            return "results_" + date.ToString("yyyyMMdd_HHmmss") + "_" + type.ToString() + "_" + group + "_" + participant_id.ToString() + "_" + difficulty.ToString() + "_" + activity_id.ToString() + ".json";
        }

    }

