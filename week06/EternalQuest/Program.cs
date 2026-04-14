/*
  Creative Features Added:
 - Users level up every 1000 points to add motivation beyond scoring.
 - Goals show clear status indicators ([ ], [X], [∞]) and progress tracking (e.g. 2/5).
 */
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}