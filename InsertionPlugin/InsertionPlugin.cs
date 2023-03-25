namespace PluginPile.InsertionPlugin {
  public class InsertionPlugin : Common.PluginBase {
    public override string Name => nameof(InsertionPlugin);

    protected override void LoadMenu(ToolStripDropDownItem tools) {
      ToolStripMenuItem insertionPluginButton = new ToolStripMenuItem(Properties.Text.MenuItemName);
      insertionPluginButton.Click += (s, e) => new PositionForm(SaveFileEditor).ShowDialog();
      tools.DropDownItems.Add(insertionPluginButton);
    }

  }
}