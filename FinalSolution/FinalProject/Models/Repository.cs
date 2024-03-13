namespace FinalProject.Models {
    public static class Repository {
        private static Week _week = new();

        public static Week Week => _week;

    }
}