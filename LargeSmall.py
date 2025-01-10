import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import math
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
# 12, and 5, 20, or 35 for the group size 60. The ratio of responding agents to 
# the whole number of agents is 1/12, 4/12, or 7/12
# first, separate large (60) and small groups (12), then number of responding agents
NRA_60 = np.reshape(np.where([TNA_main == 60],NRA_main,np.nan),[np.size(NRA_main,0),np.size(NRA_main,1)])
RLH_60 = np.reshape(np.where([TNA_main == 60],RLH_main,np.nan),[np.size(RLH_main,0),np.size(RLH_main,1)])
Response_60 = np.reshape(np.where([TNA_main == 60],Response_main,np.nan),[np.size(Response_main,0),np.size(Response_main,1)])
RT_60 = np.reshape(np.where([TNA_main == 60],RT_main,np.nan),[np.size(RT_main,0),np.size(RT_main,1)])
DC_60 = np.reshape(np.where([TNA_main == 60],DC_main,np.nan),[np.size(DC_main,0),np.size(DC_main,1)])

NRA_12 = np.reshape(np.where([TNA_main == 12],NRA_main,np.nan),[np.size(NRA_main,0),np.size(NRA_main,1)])
RLH_12 = np.reshape(np.where([TNA_main == 12],RLH_main,np.nan),[np.size(RLH_main,0),np.size(RLH_main,1)])
Response_12 = np.reshape(np.where([TNA_main == 12],Response_main,np.nan),[np.size(Response_main,0),np.size(Response_main,1)])
RT_12 = np.reshape(np.where([TNA_main == 12],RT_main,np.nan),[np.size(RT_main,0),np.size(RT_main,1)])
DC_12 = np.reshape(np.where([TNA_main == 12],DC_main,np.nan),[np.size(DC_main,0),np.size(DC_main,1)])
# =============================================================================
RLH_60_1 = np.reshape(np.where([NRA_60 == 5], RLH_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
Response_60_1 = np.reshape(np.where([NRA_60 == 5], Response_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
RT_60_1 = np.reshape(np.where([NRA_60 == 5], RT_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
DC_60_1 = np.reshape(np.where([NRA_60 == 5], DC_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])

RLH_60_4 = np.reshape(np.where([NRA_60 == 20], RLH_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
Response_60_4 = np.reshape(np.where([NRA_60 == 20], Response_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
RT_60_4 = np.reshape(np.where([NRA_60 == 20], RT_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
DC_60_4 = np.reshape(np.where([NRA_60 == 20], DC_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])

RLH_60_7 = np.reshape(np.where([NRA_60 == 35], RLH_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
Response_60_7 = np.reshape(np.where([NRA_60 == 35], Response_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
RT_60_7 = np.reshape(np.where([NRA_60 == 35], RT_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
DC_60_7 = np.reshape(np.where([NRA_60 == 35], DC_60,np.nan),[np.size(NRA_60,0),np.size(NRA_60,1)])
# =============================================================================
RLH_12_1 = np.reshape(np.where([NRA_12 == 1], RLH_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
Response_12_1 = np.reshape(np.where([NRA_12 == 1], Response_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
RT_12_1 = np.reshape(np.where([NRA_12 == 1], RT_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
DC_12_1 = np.reshape(np.where([NRA_12 == 1], DC_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])

RLH_12_4 = np.reshape(np.where([NRA_12 == 4], RLH_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
Response_12_4 = np.reshape(np.where([NRA_12 == 4], Response_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
RT_12_4 = np.reshape(np.where([NRA_12 == 4], RT_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
DC_12_4 = np.reshape(np.where([NRA_12 == 4], DC_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])

RLH_12_7 = np.reshape(np.where([NRA_12 == 7], RLH_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
Response_12_7 = np.reshape(np.where([NRA_12 == 7], Response_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
RT_12_7 = np.reshape(np.where([NRA_12 == 7], RT_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])
DC_12_7 = np.reshape(np.where([NRA_12 == 7], DC_12,np.nan),[np.size(NRA_12,0),np.size(NRA_12,1)])

# =============================================================================
# analyzing percentage of follow ==============================================
# =============================================================================
Follow_60_1 = abs(Response_60_1 - RLH_60_1) == 1
all_60_1 = np.sum(~np.isnan(RLH_60_1), axis = 1)
Follow_60_1_sum = np.sum(Follow_60_1)
Following_60_1 = Follow_60_1_sum/all_60_1

Follow_60_4 = abs(Response_60_4 - RLH_60_4) == 1
all_60_4 = np.sum(~np.isnan(RLH_60_4), axis = 1)
Follow_60_4_sum = np.sum(Follow_60_4)
Following_60_4 = Follow_60_4_sum/all_60_4

Follow_60_7 = abs(Response_60_7 - RLH_60_7) == 1
all_60_7 = np.sum(~np.isnan(RLH_60_7), axis = 1)
Follow_60_7_sum = np.sum(Follow_60_7)
Following_60_7 = Follow_60_7_sum/all_60_7

Follow_12_1 = abs(Response_12_1 - RLH_12_1) == 1
all_12_1 = np.sum(~np.isnan(RLH_12_1), axis = 1)
Follow_12_1_sum = np.sum(Follow_12_1)
Following_12_1 = Follow_12_1_sum/all_12_1

Follow_12_4 = abs(Response_12_4 - RLH_12_4) == 1
all_12_4 = np.sum(~np.isnan(RLH_12_4), axis = 1)
Follow_12_4_sum = np.sum(Follow_12_4)
Following_12_4 = Follow_12_4_sum/all_12_4

Follow_12_7 = abs(Response_12_7 - RLH_12_7) == 1
all_12_7 = np.sum(~np.isnan(RLH_12_7), axis = 1)
Follow_12_7_sum = np.sum(Follow_12_7)
Following_12_7 = Follow_12_7_sum/all_12_7

Follow_12 = np.empty((8,3))
Follow_12[:,0] = Following_12_1
Follow_12[:,1] = Following_12_4
Follow_12[:,2] = Following_12_7

Follow_60 = np.empty((8,3))
Follow_60[:,0] = Following_60_1
Follow_60[:,1] = Following_60_4
Follow_60[:,2] = Following_60_7

mean_Follow_12 = np.mean(Follow_12,axis=0)
mean_Follow_60 = np.mean(Follow_60,axis=0)

CI_Follow_12 = 1.96*np.std(Follow_12,axis=0)/math.sqrt(8)       # 95% confidence interval
CI_Follow_60 = 1.96*np.std(Follow_60,axis=0)/math.sqrt(8) 

plt.xlim(0.5,3.5)
plt.ylim(3.5,7)
plt.xlabel('ratio of responding agents to the present agents')
plt.ylabel('follow percentage')
plt.xticks([1,2,3],['1/12','4/12','7/12'])
# plt.bar(np.arange(1,4),mean_Follow_12)

# plt.bar(np.arange(1,4),mean_Follow_60)
plt.plot(np.arange(1,4),mean_Follow_12,'-o', color='#005249')
plt.plot(np.arange(1,4),mean_Follow_60,'-o', color='#fb7d07')
plt.errorbar(np.arange(1,4),mean_Follow_12,CI_Follow_12)
plt.errorbar(np.arange(1,4),mean_Follow_60,CI_Follow_60)
plt.show()

# =============================================================================
# analyzing response time =====================================================
# =============================================================================
RT_12_1_mean = np.nanmean(RT_12_1, axis=1)
RT_12_4_mean = np.nanmean(RT_12_4, axis=1)
RT_12_7_mean = np.nanmean(RT_12_7, axis=1)

RT_60_1_mean = np.nanmean(RT_60_1, axis=1)
RT_60_4_mean = np.nanmean(RT_60_4, axis=1)
RT_60_7_mean = np.nanmean(RT_60_7, axis=1)

RT_12_mean_all = np.empty((8,3))
RT_12_mean_all[:,0] = RT_12_1_mean
RT_12_mean_all[:,1] = RT_12_4_mean
RT_12_mean_all[:,2] = RT_12_7_mean

RT_60_mean_all = np.empty((8,3))
RT_60_mean_all[:,0] = RT_60_1_mean
RT_60_mean_all[:,1] = RT_60_4_mean
RT_60_mean_all[:,2] = RT_60_7_mean

mean_RT_12 = np.mean(RT_12_mean_all,axis=0)
mean_RT_60 = np.mean(RT_60_mean_all,axis=0)

CI_RT_12 = 1.96*np.std(RT_12_mean_all,axis=0)/math.sqrt(8)       # 95% confidence interval
CI_RT_60 = 1.96*np.std(RT_60_mean_all,axis=0)/math.sqrt(8) 

plt.xlim(0.5,3.5)
plt.ylim(2.4,3.4)
plt.xlabel('ratio of responding agents to the present agents')
plt.ylabel('response time (s)')
plt.xticks([1,2,3],['1/12','4/12','7/12'])
plt.plot(np.arange(1,4),mean_RT_12,'-o', color='#005249')
plt.plot(np.arange(1,4),mean_RT_60,'-o', color='#fb7d07')
plt.errorbar(np.arange(1,4),mean_RT_12,CI_RT_12)
plt.errorbar(np.arange(1,4),mean_RT_60,CI_RT_60)
plt.show()