EnsureDataLoaded();

ScriptMessage("Enabling debug mode");

UndertaleModLib.Compiler.CodeImportGroup importGroup = new(Data);

string displayName = Data.GeneralInfo.DisplayName.Content;

if (displayName == "DELTARUNE Chapter 1")
{
    ScriptMessage("Detected DELTARUNE Chapter 1 - modifying obj_initializer2");
    
    var obj_initializer2 = Data.GameObjects.ByName("obj_initializer2");
    if (obj_initializer2 == null)
    {
        ScriptError("Could not find obj_initializer2");
        return;
    }

    var createCode = obj_initializer2.EventHandlerFor(EventType.Create, (uint)0, Data);
    if (createCode == null)
    {
        ScriptError("Could not find Create event for obj_initializer2");
        return;
    }

    importGroup.QueueFindReplace(createCode,
        "global.debug = 0;",
        "global.debug = 1;"
    );

    importGroup.Import();
    ChangeSelection(createCode);
    
    ScriptMessage("Debug mode is now permanently enabled for DELTARUNE Chapter 1! Coded By Cyn-ically");
}
else if (displayName == "DELTARUNE Chapter 2")
{
    ScriptMessage("Detected DELTARUNE Chapter 2 - modifying multiple objects");
    
    var obj_initializer2 = Data.GameObjects.ByName("obj_initializer2");
    if (obj_initializer2 != null)
    {
        var initCode = obj_initializer2.EventHandlerFor(EventType.Create, (uint)0, Data);
        if (initCode != null)
        {
            importGroup.QueueFindReplace(initCode, "global.debug = 0;", "global.debug = 1;");
        }
    }

    importGroup.Import();
    ScriptMessage("Debug mode is now permanently enabled for DELTARUNE Chapter 2! Coded By Cyn-ically");
}

else if (displayName == "DELTARUNE Chapter 3")
{
    ScriptMessage("Detected DELTARUNE Chapter 3 - modifying one object");
    var obj_b0entrance = Data.GameObjects.ByName("obj_b0entrance");
    if (obj_b0entrance != null)
    {
        var createCode = obj_b0entrance.EventHandlerFor(EventType.Create, (uint)0, Data);
        if (createCode != null)
        {
            importGroup.QueueFindReplace(createCode,
                "visit = 0;",
                "visit = 0;\nchemg_show_room=1");
        }

        var drawCode = obj_b0entrance.EventHandlerFor(EventType.Draw, (uint)0, Data);
        if (drawCode != null)
        {
            importGroup.QueueFindReplace(drawCode,
                "global variable name 'chemg_show_room' index (100994) not set before reading it.",
                "false");
        }
    }

    
    var obj_initializer2 = Data.GameObjects.ByName("obj_initializer2");
    if (obj_initializer2 != null)
    {
        var initCode = obj_initializer2.EventHandlerFor(EventType.Create, (uint)0, Data);
        if (initCode != null)
        {
            importGroup.QueueFindReplace(initCode, "global.debug = 0;", "global.debug = 1;");
        }
    }

    importGroup.Import();
    ScriptMessage("Debug mode is now permanently enabled for DELTARUNE Chapter 3! Coded By Cyn-ically");
}
else if (displayName == "DELTARUNE Chapter 4")
{
    ScriptMessage("Detected DELTARUNE Chapter 4 - modifying multiple objects");
  

    
    var obj_initializer2 = Data.GameObjects.ByName("obj_initializer2");
    if (obj_initializer2 != null)
    {
        var initCode = obj_initializer2.EventHandlerFor(EventType.Create, (uint)0, Data);
        if (initCode != null)
        {
            importGroup.QueueFindReplace(initCode, "global.debug = 0;", "global.debug = 1;");
        }
    }

    importGroup.Import();
    ScriptMessage("Debug mode is now permanently enabled for DELTARUNE Chapter 4! Coded By Cyn-ically");
}
else if (displayName == "DELTARUNE")
{
    ScriptMessage("Detected DELTARUNE - modifying obj_CHAPTER_SELECT");
    
    var obj_chapter_select = Data.GameObjects.ByName("obj_CHAPTER_SELECT");
    if (obj_chapter_select == null)
    {
        ScriptError("Could not find obj_CHAPTER_SELECT");
        return;
    }

    var createCode = obj_chapter_select.EventHandlerFor(EventType.Create, (uint)0, Data);
    if (createCode == null)
    {
        ScriptError("Could not find Create event for obj_CHAPTER_SELECT");
        return;
    }

    importGroup.QueueFindReplace(createCode,
        "global.debug = 0;",
        "global.debug = 1;"
    );

    importGroup.Import();
    ChangeSelection(createCode);
    
    ScriptMessage("Debug mode is now permanently enabled for DELTARUNE! Coded By Cyn-ically");
}
else
{
    ScriptError("Unsupported version how? Current game: " + displayName);
    return;
}
