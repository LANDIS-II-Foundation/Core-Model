//  Author: Jimm Domingo, UW-Madison, FLEL

using Edu.Wisc.Forest.Flel.Util;

namespace Landis.Core
{
    /// <summary>
    /// Base class for extensions.
    /// </summary>
    public abstract class ExtensionMain
    {
        private string name;
        private ExtensionType type;
        private int timestep;

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        protected ExtensionMain(string        name,
                                ExtensionType type)
        {
            this.name = name;
            this.type = type;
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The extension's name.
        /// </summary>
        public string Name
        {
            get {
                return name;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The extension's type.
        /// </summary>
		[System.Obsolete("Use the Type property instead.")]
        public ExtensionType PlugInType
        {
            get {
                return Type;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The extension's type.
        /// </summary>
        public ExtensionType Type
        {
            get {
                return type;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// The extension's timestep (years).
        /// </summary>
        public int Timestep
        {
            get {
                return timestep;
            }

            protected set {
                timestep = value;
            }
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Initializes the extension with a data file.
        /// </summary>
        public abstract void Initialize();

        //---------------------------------------------------------------------

        /// <summary>
        /// Loads parameters for the extension from a data file.
        /// </summary>
        /// <param name="dataFile">
        /// Path to the file with initialization data.
        /// </param>
        /// <param name="modelCore">
        /// The model's core framework.
        /// </param>
        public abstract void LoadParameters(string dataFile, ICore modelCore);

        //---------------------------------------------------------------------

        /// <summary>
        /// Runs the extension for the current timestep.
        /// </summary>
        public abstract void Run();

        //---------------------------------------------------------------------

        /// <summary>
        /// Performs 2nd phase of extension initialization
        /// </summary>
        public virtual void InitializePhase2()
        {
            // Available to be implemented by extensions
        }

        //---------------------------------------------------------------------

        /// <summary>
        /// Runs after final timestep allowing extensions to release resources
        /// </summary>
        public virtual void CleanUp()
        {
            // Available to be implemented by extensions
        }

        //---------------------------------------------------------------------
    }
}
