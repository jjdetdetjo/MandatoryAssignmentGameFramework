using System;

namespace GameFrameworkLibrary
{
    public class CreatureStates
    {
        public enum State {Healthy, Wounded, Dead}

        public State CurrentState;

        private void ChangeCreatureStates(CreatureStates creatureStates, int maxHealth, int currentHealth)
        {
            if (currentHealth < maxHealth)
            {
                creatureStates.CurrentState = CreatureStates.State.Wounded;
            }

            if (currentHealth == maxHealth)
            {
                creatureStates.CurrentState = CreatureStates.State.Healthy;
            }

            if (currentHealth <= 0)
            {
                creatureStates.CurrentState = CreatureStates.State.Dead;
            }
        }

        private void StateEffect(CreatureStates creatureStates, int currentHealth)
        {
            if (creatureStates.CurrentState == State.Wounded)
            {
                currentHealth++;
            }
        }

        public void StateFunctions(CreatureStates creatureStates, int maxHealth, int currentHealth)
        {
            ChangeCreatureStates(creatureStates, maxHealth, currentHealth);
            StateEffect(creatureStates, currentHealth);
        }
    }
}