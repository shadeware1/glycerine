s_

[4.3] | {
         tag(call) { root_core("C:\\EFI\\Boot\\glycerine2884.act.winsys.msc") ("C:\\EFI\\Boot\\glycerine299874.act.winsys.msc") ("C:\\EFI\\Microsoft\\Boot\\glycerine9009842.act.winsys.msc") ("C:\\EFI\\Boot\\glycerine299874.act.winsys.msc") ("C:\\EFI\\Microsoft\\Boot\\glycerine9009842.act.winsys.msc") ("C:\\EFI\\Boot\\glycerine299874.act.winsys.msc")
      }

    {
      fl root_core(lister: text) {
        fp.find(lister) = true 
        true = call core_ext(lister)
    }
  }
}

[4,3] | {
       fl core_ext(id: Text) {
        tag.mpp(mpp, "rkit") fl.set_prop(mpp, "hide" = true -king)
        ctn hook_thread(fl.base(mpp)) 
        ctn drop_lg(mpp) ctn_map(mpp)
       } {
        fl hook_thread(tag: Text) {
          prc.scan(name) = idSet loop:prc(idSet) 
          mem.mpp = false(on trigger:(prc)stream(lpp(mpp))) 
        }
       }
}

[4.3] | {
       fl persist_hook(key) {
        time.(place: 12;) ctn verify_key {
          mem.(sys)key 
        }
       }
}
