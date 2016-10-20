namespace Refactor.Models
{
    public class SubjectiveEstimation
    {
        private string origin;
        private bool availability;
        private bool worth;
        private string recommendation;

        public SubjectiveEstimation() { }
        public SubjectiveEstimation(string o, bool a, bool w, string r)
        {
            origin = o;
            availability = a;
            worth = w;
            recommendation = r;
        }
    }
}
