using Builder;

Fabricante fabricante = new Fabricante();

NotebookBuilder notebookBuilder = new NotebookBuilder();
DesktopBuilder desktopBuilder = new DesktopBuilder();

fabricante.Build(notebookBuilder);
fabricante.Build(desktopBuilder);

Console.ReadLine();