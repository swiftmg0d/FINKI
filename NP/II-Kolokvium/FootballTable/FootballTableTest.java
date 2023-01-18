        package II_Kolokvium.FootballTable;

        import java.io.BufferedReader;
        import java.io.IOException;
        import java.io.InputStreamReader;
        import java.util.Comparator;
        import java.util.HashMap;
        import java.util.function.Function;

        /**
         * Partial exam II 2016/2017
         */
        public class FootballTableTest {
            public static void main(String[] args) throws IOException {
                FootballTable table = new FootballTable();
                BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
                reader.lines()
                        .map(line -> line.split(";"))
                        .forEach(parts -> table.addGame(parts[0], parts[1],
                                Integer.parseInt(parts[2]),
                                Integer.parseInt(parts[3])));
                reader.close();
                System.out.println("=== TABLE ===");
                System.out.printf("%-19s%5s%5s%5s%5s%5s\n", "Team", "P", "W", "D", "L", "PTS");
                table.printTable();
            }
        }

        class FootballTable{
            HashMap<String,FootballTeam>hashMap=new HashMap<>();
            public void printTable() {
                final int[] cnt = {0};
              hashMap.values().stream().
                      sorted(Comparator.comparing(FootballTeam::calculatePoints).
                              thenComparing(FootballTeam::getGoalDiffrence).reversed().
                              thenComparing(FootballTeam::getTeamName)).forEach(i->{
                          System.out.printf("%2d. %s\n", cnt[0] +=1, i);
              });
            }

            public void addGame(String teamA, String teamB, int aTeamGoals, int bTeamGoals) {
              FootballTeam a1=hashMap.computeIfAbsent(teamA,i->new FootballTeam(teamA));
              FootballTeam b2=hashMap.computeIfAbsent(teamB,i->new FootballTeam(teamB));
              a1.setGamesPlayed(a1.getGamesPlayed()+1);
              b2.setGamesPlayed(b2.getGamesPlayed()+1);
              a1.setGoalScored(a1.getGoalScored()+aTeamGoals);
              a1.setGoalConceded(a1.getGoalConceded()+bTeamGoals);
                b2.setGoalScored(b2.getGoalScored()+bTeamGoals);
                b2.setGoalConceded(b2.getGoalConceded()+aTeamGoals);
                if (aTeamGoals > bTeamGoals) {
                    a1.setWins(a1.getWins() + 1);
                    b2.setLosses(b2.getLosses()+1);
                }
                if(bTeamGoals>aTeamGoals){
                    a1.setLosses(a1.getLosses()+1);
                    b2.setWins(b2.getWins() + 1);
                }
                if(bTeamGoals==aTeamGoals){
                    a1.setDraws(a1.getDraws()+1);
                    b2.setDraws(b2.getDraws()+1);
                }

            }
        }
        class FootballTeam {
            private String teamName;
            private int gamesPlayed;
            private int wins;
            private int draws;
            private int losses;
            private int goalScored;

            public int getGoalScored() {
                return goalScored;
            }

            public void setGoalScored(int goalScored) {
                this.goalScored = goalScored;
            }

            public int getGoalConceded() {
                return goalConceded;
            }

            public void setGoalConceded(int goalConceded) {
                this.goalConceded = goalConceded;
            }

            private int goalConceded;
            public FootballTeam(String teamName) {
                goalConceded=0;
                goalConceded=0;
                this.teamName=teamName;
                gamesPlayed=0;
                wins=0;
                draws=0;
                losses=0;

            }

            public int getGoalDiffrence() {
                return goalScored-goalConceded;
            }


            public int calculatePoints(){
                return 3*wins+draws*1;
            }

            public FootballTeam(String teamName, int gamesPlayed, int wins, int draws, int losses) {
                this.teamName = teamName;
                this.gamesPlayed = gamesPlayed;
                this.wins = wins;
                this.draws = draws;
                this.losses = losses;
            }

            @Override
            public String toString() {
               return String.format("%-15s%5d%5d%5d%5d%5d", teamName, gamesPlayed, wins, draws, losses, calculatePoints());
            }

            public String getTeamName() {
                return teamName;
            }

            public void setTeamName(String teamName) {
                this.teamName = teamName;
            }

            public int getGamesPlayed() {
                return gamesPlayed;
            }

            public void setGamesPlayed(int gamesPlayed) {
                this.gamesPlayed = gamesPlayed;
            }

            public int getWins() {
                return wins;
            }

            public void setWins(int wins) {
                this.wins = wins;
            }

            public int getDraws() {
                return draws;
            }

            public void setDraws(int draws) {
                this.draws = draws;
            }

            public int getLosses() {
                return losses;
            }

            public void setLosses(int losses) {
                this.losses = losses;
            }
        }
