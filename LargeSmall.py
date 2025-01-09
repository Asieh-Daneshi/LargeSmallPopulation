import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
# =============================================================================
# Read and separate date just for "LargeSmall" experiment
data = pd.read_excel('Responses.xlsx')
b = 0
Data = pd.DataFrame()
for a in np.arange(0,len(data)):
    if data.iloc[a,2] == 'LargeSmall':
        Data = pd.concat([Data,(data.iloc[a,:]).to_frame().T])
        # Data.iloc[b,:] = (data.iloc[a,:]).to_frame().T
        b = b+1
# =============================================================================
# element 0: session index, practice = 1, test = 2
# element 1: catch index, catch = 1, main = 0
# element 2: total number of agents (group size)
# element 3: number of responding agents
# element 4: right or left hand, right hand = 2, left hand = 1
# element 5: response, right = 1, left = 2, missed = 0
# element 6: response time
# element 7: Dominant color, Blue: DC = 1, Yellow: DC = 2
# attention!: always right hand: yellow, left hand: blue
NP = len(Data)      # number of participants
DataTrain = Data.iloc[:,4:24]       # 20 train trails
DataTest = Data.iloc[:,24:264]      # 240 test trials

# initiate arrays for train data ==============================================
SI_train = np.empty((NP,20))
CI_train = np.empty((NP,20))
TNA_train = np.empty((NP,20))
NRA_train = np.empty((NP,20))
RLH_train = np.empty((NP,20))
Response_train = np.empty((NP,20))
RT_train = np.empty((NP,20))
DC_train = np.empty((NP,20))

# initiate arrays for test data ===============================================
SI_test = np.empty((NP,240))
CI_test = np.empty((NP,240))
TNA_test = np.empty((NP,240))
NRA_test = np.empty((NP,240))
RLH_test = np.empty((NP,240))
Response_test = np.empty((NP,240))
RT_test = np.empty((NP,240))
DC_test = np.empty((NP,240))

# =============================================================================
for a1 in np.arange(0,NP):
    for a2 in np.arange(0,20):
        temp = (DataTrain.iloc[a1,a2]).split(",")
        SI_train[a1,a2] = temp[0]
        CI_train[a1,a2] = temp[1]
        TNA_train[a1,a2] = temp[2]
        NRA_train[a1,a2] = temp[3]
        RLH_train[a1,a2] = temp[4]
        Response_train[a1,a2] = temp[5]
        RT_train[a1,a2] = temp[6]
        DC_train[a1,a2] = temp[7]
    for a3 in np.arange(0,240):
        temp = (DataTest.iloc[a1,a3]).split(",")
        SI_test[a1,a3] = temp[0]
        CI_test[a1,a3] = temp[1]
        TNA_test[a1,a3] = temp[2]
        NRA_test[a1,a3] = temp[3]
        RLH_test[a1,a3] = temp[4]
        Response_test[a1,a3] = temp[5]
        RT_test[a1,a3] = temp[6]
        DC_test[a1,a3] = temp[7]
# =============================================================================
# here, I separate catch trials and main trails (just for test data)
# initiate "catch" and "main" arrays ==========================================
TNA_catch = np.empty((NP,240));TNA_catch[:] = np.nan
NRA_catch = np.empty((NP,240));NRA_catch[:] = np.nan
RLH_catch = np.empty((NP,240));RLH_catch[:] = np.nan
Response_catch = np.empty((NP,240));Response_catch[:] = np.nan
RT_catch = np.empty((NP,240));RT_catch[:] = np.nan
DC_catch = np.empty((NP,240));DC_catch[:] = np.nan

TNA_main = np.empty((NP,240));TNA_main[:] = np.nan
NRA_main = np.empty((NP,240));NRA_main[:] = np.nan
RLH_main = np.empty((NP,240));RLH_main[:] = np.nan
Response_main = np.empty((NP,240));Response_main[:] = np.nan
RT_main = np.empty((NP,240));RT_main[:] = np.nan
DC_main = np.empty((NP,240));DC_main[:] = np.nan
# =============================================================================
for b1 in np.arange(0,NP):
    n_main = 0
    n_catch = 0
    for b2 in np.arange(0,240-1):
        if CI_test[b1,b2] == 0:     # main trial
            TNA_main[b1,n_main] = TNA_test[b1,b2]
            NRA_main[b1,n_main] = NRA_test[b1,b2]
            RLH_main[b1,n_main] = RLH_test[b1,b2]
            Response_main[b1,n_main] = Response_test[b1,b2]
            RT_main[b1,n_main] = RT_test[b1,b2]
            DC_main[b1,n_main] = DC_test[b1,b2]
            n_main = n_main+1
        else:                       # catch trial
            TNA_catch[b1,n_catch] = TNA_test[b1,b2]
            NRA_catch[b1,n_catch] = NRA_test[b1,b2]
            RLH_catch[b1,n_catch] = RLH_test[b1,b2]
            Response_catch[b1,n_catch] = Response_test[b1,b2]
            RT_catch[b1,n_catch] = RT_test[b1,b2]
            DC_catch[b1,n_catch] = DC_test[b1,b2]
            n_catch = n_catch+1          
# =============================================================================
# Detecting and removing outliers =============================================
correct_catch = np.sum(abs(Response_catch - DC_catch) == 1, axis = 1)   # number of correct catch trials
all_catch = np.sum(~np.isnan(Response_catch), axis = 1)
PercentCorrect = correct_catch/all_catch
plt.bar(np.arange(1,11),PercentCorrect)
Q1 = np.quantile(PercentCorrect,.25)
Q3 = np.quantile(PercentCorrect,.75)
OutlierIndices = (PercentCorrect <= Q1-(1.5*(Q3-Q1))).astype(int)
TNA_main = np.delete(TNA_main, OutlierIndices, axis = 0)
NRA_main = np.delete(NRA_main, OutlierIndices, axis = 0)
RLH_main = np.delete(RLH_main, OutlierIndices, axis = 0)
Response_main = np.delete(Response_main, OutlierIndices, axis = 0)
RT_main = np.delete(RT_main, OutlierIndices, axis = 0)
DC_main = np.delete(DC_main, OutlierIndices, axis = 0)
# =============================================================================
# We have two main factors: total number of agents (group size) that can be 12 
# or 60, and number of responding agents that can be 1, 4, or 7 for the group size
# 12, and 5, 20, or 35 for the group size 60



Follow = abs(Response_main - RLH_main) == 1
all_main = np.sum(~np.isnan(RLH_main), axis = 1)
Follow_main = np.sum(Follow)
Follow_main/all_main
