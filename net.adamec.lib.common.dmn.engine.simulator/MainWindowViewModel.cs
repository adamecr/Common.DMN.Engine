using net.adamec.lib.common.dmn.engine.simulator.mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;
using net.adamec.lib.common.dmn.engine.simulator.controls.dmnworkplace.model;
using net.adamec.lib.common.dmn.engine.simulator.model.dummy;

namespace net.adamec.lib.common.dmn.engine.simulator;

public class MainWindowViewModel : ViewModelBase
{
    /// <summary>
    /// Design time mock
    /// </summary>
    public static MainWindowViewModel DesignTime;

    /// <summary>
    /// Static CTOR - adds the know DMN files to DesignTime mock
    /// </summary>
    static MainWindowViewModel()
    {
        DesignTime = new MainWindowViewModel();
        if (DummyModel.IsDesignTime)
        {
            foreach (var knownDmnFile in GetKnownDmnFiles())
            {
                DesignTime.DmnWorkspaceModels.Add(new DmnWorkspaceModel(knownDmnFile));
            }
        }
        
    }

    /// <summary>
    /// All DMN model workspaces
    /// </summary>
    public ObservableCollection<DmnWorkspaceModel> DmnWorkspaceModels { get; } = new();

    /// <summary>
    /// Current DMN Workspace (model)
    /// </summary>
    private DmnWorkspaceModel? currentDmnWorkspaceModel;

    /// <summary>
    /// Current DMN Workspace (model)
    /// </summary>
    public DmnWorkspaceModel? CurrentDmnWorkspaceModel
    {
        get => currentDmnWorkspaceModel;
        set => Change(ref currentDmnWorkspaceModel, value);
    }

    /// <summary>
    /// Command used to add DMN file workspace
    /// </summary>
    private RelayCommand? addDmnCommand;
    /// <summary>
    /// Command used to add DMN file workspace
    /// </summary>
    public ICommand AddDmnCommand => addDmnCommand ??= new RelayCommand(AddDmnWorkspace);

    /// <summary>
    /// Command used to close DMN model workspace
    /// </summary>
    private RelayCommand? closeDmnCommand;

    /// <summary>
    /// Command used to close DMN model workspace
    /// </summary>
    public ICommand CloseDmnCommand => closeDmnCommand ??= new RelayCommand(CloseDmnWorkspace);

    /// <summary>
    /// Source of the items for the drop down menu of the Add DMN button
    /// Full path-file name for the known files, string.Empty-title for the add from file option
    /// </summary>
    public Dictionary<string, string> AddDmnMenuItemsDict => GetAddDmnMenuItems();

    
    /// <summary>
    /// Adds the DMN workspace - "opens" the DMN file given in command <paramref name="parameter"/>.
    /// When the file name is not provided, the open file dialog is used to choose a file.
    /// </summary>
    /// <param name="parameter">Optional full path to DMN file to open the workspace for</param>
    public void AddDmnWorkspace(object? parameter)
    {
        var fileName = parameter?.ToString() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(fileName))
        {
            //Open file
            var dialog = new OpenFileDialog
            {
                Title = "Open DMN file",
                AddExtension = true,
                DefaultExt = ".dmn",
                CheckFileExists = true,
            };
            if (dialog.ShowDialog() ?? false)
            {
                fileName = dialog.FileName;
            }
            else
            {
                return;
            }

        }

        var model = new DmnWorkspaceModel(fileName);
        DmnWorkspaceModels.Add(model);
        CurrentDmnWorkspaceModel = model;
    }

    /// <summary>
    /// Close DMN workspace
    /// </summary>
    /// <param name="parameter">Command parameter - not used</param>
    public void CloseDmnWorkspace(object? parameter)
    {
        if (parameter is DmnWorkspaceModel dmnViewModel)
            DmnWorkspaceModels.Remove(dmnViewModel);
    }

    /// <summary>
    /// Get the array of known DMN files - names of the DMN files in the DMN subdirectory of the application directory
    /// </summary>
    /// <returns>Get the array of known DMN files (full paths)</returns>
    private static string[] GetKnownDmnFiles()
    {
        var dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dmn");
        var files = Directory.GetFiles(dirPath, "*.dmn");
        return files;
    }

    /// <summary>
    /// Builds a dictionary (full path - file name) of the items to be presented in Add DMN menu
    /// It gets <see cref="GetKnownDmnFiles">known DMN files</see> as the items
    /// plus it adds the "Add from file" as the last option (the dictionary key is string.Empty)
    /// </summary>
    /// <returns>Dictionary of the items to be presented in Add DMN menu</returns>
    private Dictionary<string, string> GetAddDmnMenuItems()
    {
        var dict = new Dictionary<string, string>();
        foreach (var knownDmnFile in GetKnownDmnFiles())
        {
            var fileName = Path.GetFileName(knownDmnFile);
            dict.Add(knownDmnFile, fileName);

        }

        //Add from file option
        dict.Add(string.Empty, "Add from file...");

        return dict;
    }

}