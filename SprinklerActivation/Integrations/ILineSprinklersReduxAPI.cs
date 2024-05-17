using SObject = StardewValley.Object;

namespace LineSprinklersRedux
{
    public interface ILineSprinklersReduxAPI
    {
        /// <summary>
        ///   Plays the Sprinkler Animation for a given Sprinkler Object.
        /// </summary>
        /// <param name="sprinkler">The sprinkler Object for which to play animation</param>
        /// <param name="delayBeforeAnimationStart">The delay in milliseconds before playing the sprinkler.</param>
        void PlaySprinklerAnimation(SObject sprinkler, int delayBeforeAnimationStart);

        /// <summary>
        ///   Waters the tiles covered by the sprinkler passed as a parameter. This method does NOT
        ///   play the animation. To play animation, see PlaySprinklerAnimation
        /// </summary>
        /// <param name="sprinkler">The sprinkler Object whose tiles should be watered.</param>
        void ApplySprinkler(SObject sprinkler);

        /// <summary>
        ///  Returns true if the passed object is a LineSprinkler owned by this mod.
        /// </summary>
        /// <param name="sprinkler">The sprinkler to be checked.</param>
        bool IsLineSprinkler(SObject sprinkler);
    }
}
