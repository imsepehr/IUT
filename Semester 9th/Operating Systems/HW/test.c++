semaphore s1=1;
semaphore s2=15;

procedure Cave_exploration():
    Enter_the_cave();
    Look_at_the_paintings();
    Exit_the_cave();

procedure Enter_the_cave():
    wait(s1);
    wait(s2);
    signal(s1);

procedure Look_at_the_paintings():


procedure Exit_the_cave():
    wait(s1);
    signal(s2);
    signal(s1);

    

writerLock(){
    lock(mutex);
    writer_waiting += 1;
    while(readcount > 0 || writer_present){
        wait(writer_enter, mutex);
    }
    writer_waiting -= 1;
    writer_present = True;
    unlock(mutex);
}

readLock(){
    lock(mutex);
    while(writer_present || writer_waiting > 0){
        wait(reader_enter, mutex);
    }
    readcount += 1;
    unlock(mutex);
}

writeUnlock(){
    lock(mutex);
    writer_present = False;
    if(writer_waiting ==0){
        signal(reader_enter);
    }
    else{
        signal(writer_enter);
    }
    unlock(mutex);
}

readUnlock(){
    lock(mutex);
    readcount -= 1;
    if(readcount == 0)
    {
        signal(writwr_enter);
    }
    unlock(mutex);
}
    
