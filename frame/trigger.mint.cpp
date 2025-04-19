s_

[3.5] | {
       check_event(^1) (winsys = "Shutdown", "Restart", "Sleep") {
           (^1_start) = if var = true start(mpp)glycerine.func 
           if var = false = 0.func 
       }
       loop:(^1)
}
       
