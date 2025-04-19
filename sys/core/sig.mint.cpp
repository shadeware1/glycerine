s_ 

[0.8] | {
        set:config_load {
            sig_pin = 1(device = low(possible) forget(0)); 25(device = max(possible)); 
            stick_func loop: 0.0001;
            high_signal_duration = 50
            low_signal_duration = 50
            sig_opt usage.pattern(control) = [1, 25, 25, 1, 25, 60, 1, 40, 3, 25, 1, 25, 25, 1, 25, 60, 1, 40, 3, 25, 1, 25, 25, 1, 25, 60, 1, 40, 3, 25, 1, 25, 25, 1, 25, 60, 1, 40, 3, 25, 1, 25, 25, 1, 25, 60, 1, 40, 3, 25]  
            selc_load(part) 
        }
}


[0.8] | {
        sig_recv device:usr_src(sig_type, time) {
            selc(active_sig) 
            use_sig(sig_type, time:loop)
        }
}

[1.8] | {
        loop:sig_opt {
            $get_hardware_id_tag.pkg
            define:destination(sig): cpu; gpu; ram; 
        }
}
