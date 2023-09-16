namespace _10.SoftUniCoursePlanning
{
    /*
Arrays, Lists, Methods
Swap:Arrays:Methods
Exercise:Databases
Swap:Lists:Databases
Insert:Arrays:0
course start
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine().Split(", ").ToList();
            string input;
            string lesson;
            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(':');
                switch (commands[0])
                {
                    case "Add":
                        lesson = commands[1];
                        AddLessonToSchedule(schedule, lesson);
                        break;
                    case "Insert":
                        lesson = commands[1];
                        int index = int.Parse(commands[2]);
                        InsertLessonToSchedule(schedule, lesson, index);
                        break;
                    case "Remove":
                        lesson = commands[1];
                        RemoveLessonFromSchedule(schedule, lesson);
                        break;
                    case "Swap":
                        lesson = commands[1];
                        string swapLesson = commands[2];
                        SwapLessonsFromSchedule(schedule, lesson, swapLesson);
                        break;
                    case "Exercise":
                        lesson = commands[1];
                        AddExerciseToSchedule(schedule, lesson);
                        break;
                }
            }
            for (int i = 0; i < schedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{schedule[i]}");
            }
        }

        static List<string> AddExerciseToSchedule(List<string> schedule, string lesson)
        {
            string exerciseName = $"{lesson}-Exercise";
            if (schedule.Contains(lesson) && !schedule.Contains(exerciseName))
            {
                int index = schedule.IndexOf(lesson);
                if (index == schedule.Count - 1)
                {
                    schedule.Add(exerciseName);
                }
                else
                {
                    schedule.Insert(index + 1, exerciseName);
                }
            }
            else if (!schedule.Contains(lesson))
            {
                schedule.Add(lesson);
                schedule.Add(exerciseName);
            }
            return schedule;
        }

        static List<string> SwapLessonsFromSchedule(List<string> schedule, string lesson, string swapLesson)
        {
            string swapLessonExerciseName = $"{swapLesson}-Exercise";
            string lessonExerciseName = $"{lesson}-Exercise";
            string temp;
            if (schedule.Contains(lesson) && schedule.Contains(swapLesson) && !schedule.Contains(swapLessonExerciseName) && !schedule.Contains(lessonExerciseName))
            {
                int index1 = schedule.IndexOf(lesson);
                int index2 = schedule.IndexOf(swapLesson);
                temp = schedule[index1];
                schedule[index1] = schedule[index2];
                schedule[index2] = temp;
            }
            else if (schedule.Contains(swapLessonExerciseName))
            {
                int indexOfLesson = schedule.IndexOf(lesson);
                int indexOfLesson1 = schedule.IndexOf(swapLesson);
                temp = schedule[indexOfLesson];
                schedule[indexOfLesson] = schedule[indexOfLesson1];
                schedule[indexOfLesson1] = temp;
                schedule.Insert(indexOfLesson + 1, schedule[indexOfLesson1 +1]);
                schedule.RemoveAt(indexOfLesson + 2);

                //int indexOfLesson = schedule.IndexOf(lesson);
                //temp = schedule[indexOfLesson];
                //int indexOfSwapLesson = schedule.IndexOf(swapLesson);
                //int indexOfSwapLessonExercise = schedule.IndexOf(swapLessonExerciseName);
                //if (indexOfLesson + 1 <= schedule.Count - 1)
                //{
                //    schedule[indexOfLesson] = schedule[indexOfSwapLesson];
                //    schedule.Insert(indexOfLesson + 1, schedule[indexOfSwapLessonExercise]);
                //    schedule[indexOfSwapLesson] = temp;
                //    schedule.RemoveAt(indexOfSwapLessonExercise);
                //}


            }
            else if (schedule.Contains(lessonExerciseName))
            {

            }
            //if (schedule.Contains(exerciseName))
            //{
            //    int lesson1Index = schedule.IndexOf(lesson);
            //    int exercise1index = schedule.IndexOf(exerciseName);
            //    int swapLessonIndex = schedule.IndexOf(swapLesson);
            //    temp = schedule[lesson1Index];
            //    schedule[swapLessonIndex] = schedule[lesson1Index];
            //    if (swapLessonIndex + 1 > schedule.Count - 1)
            //    {
            //        schedule.Add(exerciseName);
            //        schedule.Remove(exerciseName);
            //    }
            //    else
            //    {
            //        schedule[swapLessonIndex + 1] = exerciseName;
            //        schedule.Remove(exerciseName);
            //    }
            //    schedule[lesson1Index] = temp;
            //}
            return schedule;
        }

        static List<string> RemoveLessonFromSchedule(List<string> schedule, string lesson)
        {
            string exerciseName = $"{lesson}-Exercise";
            if (schedule.Contains(lesson))
            {
                schedule.Remove(lesson);
            }
            if (schedule.Contains(exerciseName))
            {
                schedule.Remove(exerciseName);
            }
            return schedule;
        }

        static List<string> InsertLessonToSchedule(List<string> schedule, string lesson, int index)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Insert(index, lesson);
                return schedule;
            }
            return schedule;
        }

        static List<string> AddLessonToSchedule(List<string> schedule, string lesson)
        {
            if (!schedule.Contains(lesson))
            {
                schedule.Add(lesson);
                return schedule;
            }
            return schedule;
        }
    }
}